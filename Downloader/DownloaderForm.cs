namespace Downloader
{
	using System;
	using System.ComponentModel;
	using System.Threading;
	using System.Windows.Forms;

	using global::Downloader.Properties;

	public partial class DownloaderForm : Form
	{
		private readonly SynchronizationContext _context;

		private readonly Downloader _downloader;

		public DownloaderForm()
		{
			InitializeComponent();

			_context = SynchronizationContext.Current;

			_downloader = new Downloader();
			_downloader.Downloading += Downloading;
			_downloader.DownloadCancelled += DownloadCancelled;
			_downloader.DownloadCompleted += DownloadCompleted;

			uxProgressBar.Minimum = 1;

			uxPauseButton.Click += PauseButton_Click;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			_downloader.Cancel();

			Reset();
		}

		private void DownloadButton_Click(object sender, EventArgs e)
		{
			if (!_downloader.Download("www.domain.com"))
			{
				return;
			}

			Reset();
		}

		private void DownloadCancelled(object sender, CancelEventArgs e)
		{
			_context.Send(state => Reset(), null);
		}

		private void DownloadCompleted(object sender, EventArgs e)
		{
			SetButtonsState(true);
		}

		private void Downloading(object sender, DownloaderEventArgs e)
		{
			_context.Send(state =>
			              {
							  uxCounter.Text = string.Format("{0:f0}/100: {1}", (e.Counter / (float)e.Total) * 100, e.Text);
				              uxProgressBar.Maximum = e.Total;
				              uxProgressBar.Value = e.Counter;
			              }, null);
		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			if (_downloader.Pause)
			{
				uxPauseButton.Text = Resources.Pause;

				_downloader.Pause = false;
			}
			else
			{
				uxPauseButton.Text = Resources.Continue;

				_downloader.Pause = true;
			}
		}

		private void Reset()
		{
			SetButtonsState(false);

			uxProgressBar.Value = 1;

			uxCounter.Text = string.Empty;
		}

		private void SetButtonsState(bool state)
		{
			uxDownloadButton.Enabled = state;

			uxCancelButton.Enabled = !state;

			uxPauseButton.Enabled = !uxDownloadButton.Enabled;
		}
	}
}
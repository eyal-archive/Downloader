namespace Downloader
{
	using System;
	using System.ComponentModel;
	using System.Globalization;
	using System.Threading;

	public sealed class Downloader : IDisposable
	{
		private readonly Random _random;

		private readonly AutoResetEvent _reset;

		private readonly BackgroundWorker _worker;

		private bool _pause;

		public Downloader()
		{
			_reset = new AutoResetEvent(false);

			_worker = new BackgroundWorker {
				                               WorkerSupportsCancellation = true
			                               };

			_worker.DoWork += DoWork;
			_worker.RunWorkerCompleted += RunWorkerCompleted;

			_random = new Random();

			Pause = false;
		}

		public event EventHandler<CancelEventArgs> DownloadCancelled;

		public event EventHandler DownloadCompleted;

		public event EventHandler<DownloaderEventArgs> Downloading;

		public bool Pause
		{
			get
			{
				return _pause;
			}

			set
			{
				if (!value)
				{
					_reset.Set();
				}

				_pause = value;
			}
		}

		public void Cancel()
		{
			_worker.CancelAsync();
		}

		public void Dispose()
		{
			_worker.Dispose();
		}

		public bool Download(string url)
		{
			if (_worker.IsBusy)
			{
				return false;
			}

			_worker.RunWorkerAsync(url);

			return true;
		}

		private void DoWork(object sender, DoWorkEventArgs e)
		{
			const int length = 123456;

			for (int i = 1; i <= length; i++)
			{
				if (_worker.CancellationPending)
				{
					OnDownloadCancelled(new CancelEventArgs(true));

					return;
				}

				if (Pause)
				{
					_reset.WaitOne();
				}

				OnDownloading(new DownloaderEventArgs(_random.Next().ToString(CultureInfo.InvariantCulture), i, length));
			}
		}

		private void OnDownloadCancelled(CancelEventArgs e)
		{
			var handler = DownloadCancelled;

			if (handler != null)
			{
				handler(this, e);
			}
		}

		private void OnDownloadCompleted(EventArgs e)
		{
			var handler = DownloadCompleted;

			if (handler != null)
			{
				handler(this, e);
			}
		}

		private void OnDownloading(DownloaderEventArgs e)
		{
			var handler = Downloading;

			if (handler != null)
			{
				handler(this, e);
			}
		}

		private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			OnDownloadCompleted(e);
		}
	}
}
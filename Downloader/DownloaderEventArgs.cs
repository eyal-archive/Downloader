namespace Downloader
{
	using System;

	public class DownloaderEventArgs : EventArgs
	{
		public DownloaderEventArgs(string text, int counter, int total)
		{
			Text = text;

			Total = total;

			Counter = counter;
		}

		public int Counter { get; private set; }

		public string Text { get; private set; }

		public int Total { get; private set; }
	}
}
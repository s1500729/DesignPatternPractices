﻿namespace Displayer
{
	public class Display
	{
		private DisplayImpl impl;

		public Display(DisplayImpl impl)
		{
			this.impl = impl;
		}

		public void Open()
		{
			impl.RawOpen();
		}

		public void Print()
		{
			impl.RawPrint();
		}

		public void Close()
		{
			impl.RawClose();
		}

		public void ToDisplay()
		{
			Open();
			Print();
			Close();
		}
	}
}

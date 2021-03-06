﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringDecorator
{
	public abstract class Display
	{
		public abstract int Columns { get; }
		public abstract int Rows { get; }
		public abstract string GetRowText(int row);

		public void Show()
		{
			for(var i = 0;i< Rows; i++)
			{
				Console.WriteLine(GetRowText(i));
			}
		}
		
	}
}

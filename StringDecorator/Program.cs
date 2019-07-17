using System;

namespace StringDecorator
{
	class Program
	{
		static void Main(string[] args)
		{
			var b1 = new StringDisplay("Hello, world.");
			var b2 = new SideBorder(b1, '#');
			var b3 = new FullBorder(b2);

			b1.Show();
			b2.Show();
			b3.Show();

			var b4 =
				new SideBorder(
					new FullBorder(
						new FullBorder(
							new SideBorder(
								new FullBorder(
									new StringDisplay("こんにちは。")
									),
								'*'
								)
							)
						),
					'/'
					);

			b4.Show();
		}
	}
}

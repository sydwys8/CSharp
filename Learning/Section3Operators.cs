using System;

namespace Section3App

{

	class Operators
	{

		static void Main(string[] args)
		{

			// +
			int a = 5;
			int b = 3;
			int c = a + b;
			Console.WriteLine(c);

			// -
			int d = 22 - 13;
			int e = d-3;
			Console.WriteLine(e);

			// *
			Console.WriteLine(8*9);

			// /
			double f = 10.0;
			double g = 3.0;
			Console.WriteLine(f/g);

			// %
			int h = 5;
			Console.WriteLine(h % 2);

			// ++ and --
			int i = 66;
			int j = 55;
			Console.WriteLine(i++);
			Console.WriteLine(--j);
			Console.WriteLine(i);

			// assignment
			int k = 7;
			k -= 5;
			Console.WriteLine(k);

			int l = 9;
			Console.WriteLine(l%=2);

			// ==, !, !=, >, <, <=, >=
			int m = 273;
			int n = 274;
			string str = "274";
			Console.WriteLine(m > n);
			//Console.WriteLine(n == str3);
			Console.WriteLine(n.ToString() == str);

			bool o = true;
			bool p = false;
			Console.WriteLine(o || p);

			int q = 50; // 0011 0010
			int r = 33; // 0010 0001
			// &
			Console.WriteLine(q & r);
			// 0010 0000

			// |
			Console.WriteLine(q | r);
			// 0011 0011

			// ^
			Console.WriteLine(q ^ r);
			// 0001 0011

			// ~
			Console.WriteLine(~q);
			// 1100 1101

			// <<
			Console.WriteLine(r << 1);
			// 0100 0010


		}
	}
}
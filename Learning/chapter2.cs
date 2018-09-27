using System;

namespace Chapter2App
{
	class Chapter2
	{
		static void Main(string[] args)
		{
			//Data Types
			int a = 5;
			a = 6;
			Console.WriteLine(a);

			double d = 2.2;
			decimal e = 3.14159265358979323846264338327M;
			char c = 'c';
			bool t = true;
			//bool f = 0;
			Console.WriteLine(sizeof(double));

			double b = (double) a;
			Console.WriteLine(b.GetType());

			//Constants
			object o1 = 1337;
			o1 = "char";
			Console.WriteLine(o1);


			String str1 = "input";
			// The following points to a location in memory.
			// It is considered unsafe to use this type.
			//int* intpointer;

			const int i = 64;
			//i++; <<This doesn't work
			const double pi = 3.1415926;

			//Nullable Types
			//double score1 = 45.0;
			double? score = 45.0;
			score = null;
			Console.WriteLine(score);

			double? score1 = null;
			double score2 = 67.2;
			double score3 = 88.5;
			double? avg = (score1 + score2 + score3)/ 3.0;
			// The following returns 'null' (or nothing).
			Console.WriteLine(avg);

			//Strings
			string str = "Hola!";
			char first = str[0];
			Console.WriteLine(first);
			Console.WriteLine(str.Length);

			string strA = "Hola";
			string strB = "Mundo!";
			string strC = strA + strB;
			//string strC = String.Concat(strA,strB); is the same.
			Console.WriteLine(strC);

			char [] destarr = {'a', 'b', 'c', 'd', 'e'};
			string strX = "fgh";
			strX.CopyTo(0, destarr, 0, strX.Length);
			Console.WriteLine(destarr);

		}
	}
}

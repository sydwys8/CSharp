// All C# programs use System  to provide all the keywords, methods, classes etc. required to program in C#.
using System;

namespace Chapter1App
{
	class Chapter1
	{
		static void Main(string[] args)
		{
			// This simply prints Hello World!
			Console.WriteLine("Hello World!");

			// Prints the number of Command Line arguments when you run test.exe.
			// If you simply run the program with no arguments, you will output 0.
			// In the  Command Line, you can run "test.exe arg1 arg2 ... argn" and this will output n.
			Console.WriteLine(args.Length);
		}
	}
}


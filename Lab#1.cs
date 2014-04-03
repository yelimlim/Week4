using System;

namespace lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("a? ");
			int a = int.Parse (Console.ReadLine ());

			Console.Write ("b? ");
			int b = int.Parse (Console.ReadLine ());

			Console.Write ("operation? ");
			string opr = Console.ReadLine ();

			if (opr == "/") {
				Console.WriteLine ("{0} / {1} = {2}", a, b, a / b);
			} else if (opr == "%") {
				Console.WriteLine ("{0} % {1} = {2}", a, b, a % b);
			} else if (opr == "+") {
				Console.WriteLine ("{0} + {1} = {2}", a, b, a + b);
			} else if (opr == "-") {
				Console.WriteLine ("{0} - {1} = {2}", a, b, a - b);
			} else if (opr == "*") {
				Console.WriteLine ("{0} * {1} = {2}", a, b, a * b);
			} else {
				Console.WriteLine ("You entered {0}, only +, -, *, /, % allowed", opr);
			}
		}
	}
}

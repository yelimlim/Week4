using System;

namespace lab2
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

			switch(opr){
			case "/":
				Console.WriteLine ("{0} / {1} = {2}", a, b, a / b);
				break;
			case "%":
				Console.WriteLine ("{0} % {1} = {2}", a, b, a % b);
				break;
			case "+":
				Console.WriteLine ("{0} + {1} = {2}", a, b, a + b);
				break;
			case "-":
				Console.WriteLine ("{0} - {1} = {2}", a, b, a - b);
				break;
			case "*":
				Console.WriteLine ("{0} * {1} = {2}", a, b, a * b);
				break;
			default:
				Console.WriteLine ("You entered {0}, only +, -, *, /, % allowed", opr);
				break;
			}
		}
	}
}

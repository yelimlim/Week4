using System;

namespace Constant
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Enter your number: ");
			int number = int.Parse(Console.ReadLine());

			const int SUN    = 0;
			const int MON    = 1;
			const int TUE    = 2;
			const int WED    = 3;
			const int THU    = 4;
			const int FRI    = 5;
			const int SAT    = 6;

			switch (number) {
			case SUN:
				Console.WriteLine ("Sun");
				break;
			case MON:
				Console.WriteLine ("Moon");
				break;
			case TUE:
				Console.WriteLine ("Mars");
				break;
			case WED:
				Console.WriteLine ("Mercury");
				break;
			case THU:
				Console.WriteLine ("Jupitor");
				break;
			case FRI:
				Console.WriteLine ("Venus");
				break;
			case SAT:
				Console.WriteLine ("Saturn");
				break;
			}
		}
	}
}

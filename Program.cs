using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b;
			int c;
			Console.Write("enter 1st number: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("enter 2nd number (not zero): ");
			b = Convert.ToDouble(Console.ReadLine());
			ShowMenu();
			do
			{
				c = Convert.ToInt32(Console.ReadLine());
				switch (c)
				{
					case 1:
						Console.WriteLine($"{a} + {b} = {a + b}");
						break;
					case 2:
						Console.WriteLine($"{a} - {b} = {a - b}");
						break;
					case 3:
						Console.WriteLine($"{a} * {b} = {a * b}");
						break;
					case 4:
						if (b > 0)
						{
							Console.WriteLine($"{a} / {b} = {a / b}");
						}
						else
						{
							Console.WriteLine("i told you not zero");
						}
						break;
					case 5:
						Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
						break;
					case 6:
						if (b > 0)
						{
							Console.WriteLine($"{a} ^ 1/({b}) = {Math.Pow(a, 1 / b)}");
						}
						else
						{
							Console.WriteLine("i told you not zero!");
						}
						break;
					case 7:
						Console.WriteLine("ended!");
						break;
					default:
						Console.WriteLine("please enter between 1-7");
						break;
				}
			}
			while (c != 7);			
			Console.ReadLine();

		}

		private static void ShowMenu()
		{
			Console.WriteLine("choose your choice");
			Console.WriteLine("1) 1st + 2nd");
			Console.WriteLine("2) 1st - 2nd");
			Console.WriteLine("3) 1st * 2nd");
			Console.WriteLine("4) 1st / 2nd");
			Console.WriteLine("5) 1st ^ 2nd");
			Console.WriteLine("6) 1st ^ 1/(2nd)");
			Console.WriteLine("7 or more) end");
		}
	}
}

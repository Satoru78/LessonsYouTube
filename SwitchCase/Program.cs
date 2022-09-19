using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = Console.ReadLine();

			switch(a)
			{
				case "+":
					{
						Console.WriteLine("Вы ввели плюс");
					}
					break;
				case "-":
					{
						Console.WriteLine("Вы ввели минус");
					}
					break;
				default:
					{
						Console.WriteLine("Вы ввели неизвестный символ!");
					}
					break;
			}
		}
	}
}

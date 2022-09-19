using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseHomework
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstValue;
			int secondValue;
			Console.WriteLine("Введите первое число:");
			firstValue = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			secondValue = int.Parse(Console.ReadLine());

			Console.WriteLine("Выберите действие: \n + \n - \n * \n /");
			string action = Console.ReadLine();
			switch (action)
	     	{
				case "+":
					{
						int summ = firstValue + secondValue;
						Console.WriteLine("Сумма:" + summ);
					}
					break;
				case "-":
				{
						int raz = firstValue - secondValue;
						Console.WriteLine("Разность:" + raz);
					}
					break;
				case "*":
				{
						int proz = firstValue * secondValue;
						Console.WriteLine("Произведение:" + proz);
					}
					break;
				case "/":
				{	
						if (secondValue > 0)
						{
						int chast = firstValue / secondValue;
						Console.WriteLine("Сумма:" + chast);
							
						}
						else
						{
							Console.WriteLine("Ошибка!Деление на нуль невозможно");
						}
					}
					break;
				default:
					{
						Console.WriteLine("Вы ввели неверный символ!");
					}
					break;
			}
			Console.ReadKey();
		}
	}
}

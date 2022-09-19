using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileHomework
{
	class Program
	{
		static void Main(string[] args)
		{
			uint oddNumbersCount = 0; //нечётные числа
			uint evenNumberCount = 0; //четные числа

			int oddNumdersSum = 0;
			int evenNumderSum = 0;

			Console.WriteLine("Введите первое число диапазона:");
			int currentValue = int.Parse(Console.ReadLine());

			Console.WriteLine("Введите второе число диапазона:");
			int limit = int.Parse(Console.ReadLine());

			while (currentValue <= limit)
		    {
				if (currentValue % 2 == 0)
				{
					evenNumberCount++;
					evenNumderSum += currentValue;
				}
				else
				{
					oddNumbersCount++;
					oddNumdersSum = oddNumdersSum + currentValue;
				}
				currentValue++;
			}

			Console.WriteLine("Количество нечетных чисел :" + oddNumbersCount);
			Console.WriteLine("Количество четных чисел:" + evenNumberCount);
			Console.WriteLine("Сумма нечёиных чисел:" + oddNumbersCount);
			Console.WriteLine("Сумма чётных чисел:" + evenNumderSum);
			Console.ReadLine();
		}

	}
}

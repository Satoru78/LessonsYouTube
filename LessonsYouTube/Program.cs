using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Программа конвертации валют
*/
namespace LessonsYouTube
{
	class Program
	{
		static void Main(string[] args)
		{
			double UsdToRub = 66.29;
			double RubToUsd = 27.24;
			double USD;

			Console.WriteLine("Введите сумму в USD:");

			USD = double.Parse(Console.ReadLine());

			Console.WriteLine(USD + "USD в RUB =" + USD * UsdToRub);

			Console.WriteLine(USD + "RUB в USD =" + USD * RubToUsd);
		}
	}
}

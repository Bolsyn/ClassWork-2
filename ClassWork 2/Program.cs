using System;

namespace ClassWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rand = new Random();
			// 1. вычисления значения функции y = 7x ^ 2 - 3x + 4  при любом значении x;
			int y;
			int x = rand.Next();
			y = x * x * 7 - 3 * x + 4;

			// 2. Дан радиус окружности.Найти длину окружности и площадь круга.
			double radius = rand.Next() % 10;
			double sideSqare = rand.Next() % 10;

			double sqaureOfCircle = radius * radius * 3.14;
			double squareOfSquare = sideSqare * sideSqare;
			if (squareOfSquare > sqaureOfCircle)
			{
				Console.WriteLine("Площадь квдарата больше");
			}
			else
			{
				Console.WriteLine("Площадь круга больше");
			}
			Console.WriteLine();

			// 3. Дано расстояние в сантиметрах. Найти число полных метров в нем.
			int centimeter = rand.Next() % 1000;
			int meter = centimeter / 100;
			Console.WriteLine(meter);
			Console.WriteLine();

			// 4. С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период?
			int days = 234;
			int weeks = days / 7;
			Console.WriteLine(weeks);
			Console.WriteLine();

			// 5.Дано двузначное число.Найти:
			int givenNumber = rand.Next() % 100;
			Console.WriteLine(givenNumber);

			// a.число десятков в нем;
			int decades = givenNumber / 10;
			Console.WriteLine(decades);

			// b.число единиц в нем;
			int units = givenNumber % 10;
			Console.WriteLine(units);

			// c.сумму его цифр;
			int sumDecadesAndUnits = decades + units;
			Console.WriteLine(sumDecadesAndUnits);

			// d.произведение его цифр
			int compositionDecadesAndUnits = decades * units;
			Console.WriteLine(compositionDecadesAndUnits);
			Console.WriteLine();

			// 6. Дано четырехзначное число. Найти:
			int number = rand.Next() % 8999 + 1000;
			// сумму его цифр;
			int newNumber = number;
			int sumNewNumber = 0;
			while (newNumber != 0)
            {
				sumNewNumber += newNumber % 10;
				newNumber /= 10;
			}
			// произведение его цифр.
			int newerNumber = number;
			int compositionNewerNumber = 1;
			while (newNumber != 0)
			{
				compositionNewerNumber *= newerNumber % 10;
				newerNumber /= 10;
			}
            Console.WriteLine();

			// 7. В трехзначном числе x зачеркнули его вторую цифру. 
			// Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456.Найти число x.
			y = 456;
			x = (y / 100) * 100 + (y % 10)*10+((y/10)%10);
            Console.WriteLine(x);
            Console.WriteLine();

			// 8. Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
			bool X;
			if (rand.Next() % 2 == 0)
			{
				X = true;
			}
			else
            {
				X = false;
            }
			bool Y;
			if (rand.Next() % 3 != 0)
			{
				Y = true;
			}
			else
			{
				Y = false;
			}
			// не X и не Y;
			bool nXandnY = !X && !Y;
			// X или(не X и Y);
			bool XornXandnY = X || nXandnY;
			// (не X и Y) или Y.
			bool nXandnYorY = nXandnY || Y;

		}
	}
}

using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0, c = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;
			c = 15;

			sum = a + b + 'c'; 

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" + ");
			Console.Write ( c );
			Console.Write (" = ");
			Console.WriteLine ( sum );
		}
	}
}

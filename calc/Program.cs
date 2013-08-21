using System;

namespace calc
{
	class MainClass
	{
		/*
		 * Retunere et tilfældigt tal mellem 0 og 100
		 */
		public static int random() {
			return new Random().Next(0,101);
		}

		public static void Main (string[] args)
		{
			int a = random ();
			int b = random ();

			Console.WriteLine ("Hvad er " + a.ToString () + " + " + b.ToString () + "? ");
	

			int r = 0;
			do {
				string input = Console.ReadLine ();
				r = Convert.ToInt16 (input);
				if (r != a + b) {
					Console.WriteLine ("Forkert!");
				}
			} while (r != a + b);

			Console.WriteLine ("Korrekt!");



			Console.ReadKey ();
		}
	}
}

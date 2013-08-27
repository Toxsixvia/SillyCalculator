using System;

namespace calc
{
	class MainClass
	{
		static Random rnd = new Random();
		/*
		 * Retunere et tilfældigt tal mellem 0 og 100
		 */
		public static int random() {
			
			return rnd.Next(0,101);
		}

		public static void Main (string[] args)
		{
			int a = random ();
			int b = random ();

			Console.WriteLine ("Hvad er " + a.ToString () + " + " + b.ToString () + "? ");
	

			int r = 0;
			do {
				string input = Console.ReadLine ();
				r = Convert.ToInt32 (input);
				if (r != a + b) {
					Console.WriteLine ("Forkert!");
				}
			} while (r != a + b);

			Console.WriteLine ("Korrekt!");



			Console.ReadKey ();
		}
	}
}

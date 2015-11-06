using System;

namespace stalker
{
    class Program
	{
		static void Main(string[] args)
		{
           // double v0 = 1.42;
			
			string[] name = new string[3];      // array of name
			Console.WriteLine("Input names stalkers");
			for (int i = 0; i < name.Length; i++)
			{
				name[i] = Console.ReadLine();
			}
            
			int[] cap = new int[3];             // array of capacity    
			Console.WriteLine("Input carrying capacity for each stalker");
			for (int i = 0; i < cap.Length; i++)
			{
				cap[i] = Convert.ToInt32(Console.ReadLine());
			}

			int[,] art = {{4,5,4,3,6}, {2,6,4,5,3}, {3,1,5,3,4}};   //array of items
			//Console.WriteLine("Input weight each artifacts for each stalker");
			
			
			Stalker[] S = new Stalker[3];           // array of Stalker
            for (int i = 0; i < S.Length; i++)
            {
                S[i] = new Stalker(name[i], cap[i]);
			}


            for (int i = 0; i < 3; i++)
            {
                S[i].Show();
				for (int j = 0; j < art.GetLength(1); j++)
				{
					S[i].accrue(art[i, j]);

					Console.WriteLine("Weight = " + S[i].item + "\t Speed with artifacts =" + S[i].carry());
				}
			}
			Console.ReadKey();
		}
	}
}
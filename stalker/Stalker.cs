using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stalker
{
	class Stalker
	{
		public double v0 = 1.42; //regular speep
		public string name;     // name 
		public double cap;      // capacity 
		public double item;     // the number of artifacts
         
		public Stalker(string n, int m0)    // constructor 
		{
			name = n;
			cap = m0;
		}

		public double carry()           // method: calculate speed with artifacts
		{
			double x, y, z;             // !!!REFACTORING
			x = item * item;
			y = cap * cap;
			z = 1 + x / y;
			return  v0 / (1 + item * item/cap * cap);
		}

		public void accrue(double a)    // method: calculate weight of artifacts for each stalker
		{
			item += a;
		}
		public void Show()              // method: output all data for each Stalker
		{
            Console.WriteLine("Name - " + name + " Carrying capacity = " + cap + " Weight of artifacts = " + item + " Regular speed = " + v0);
		}

	}
		
}

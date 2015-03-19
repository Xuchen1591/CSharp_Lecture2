using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_lecture2
{
	class Shape
	{
		public virtual void draw()	{Console.WriteLine("shape draw..."); }
	}

	class Rectangle : Shape
	{
		public override void draw() { Console.WriteLine("Rectangle draw..."); }
	}

	class Square : Rectangle
	{
		public sealed override void draw() { Console.WriteLine("Square drawing..."); }
		//sealed do not allow u to override , like "final" in java
	}

	class RedSquare : Square
	{
		public new void draw() { Console.WriteLine("RedSquare drawing..."); }
		//we can just use 'new ', but not 'override'
	}

	class Program
	{
		static void Main(string[] args)
		{
			/*
			//class "Array" functions
			int[] a = {1,2,4,2,455,6,2,4,6,2,9,0 };

			Array.Sort(a);
			Array.Reverse(a);

			foreach (int i in a)
				Console.WriteLine(i);
			//Array ends here
			 * */
			Shape s = new Shape();
			s.draw(); 
			//output shape
			Rectangle r = new Rectangle();
			r.draw(); 
			// output rectangle
			Shape sr = new Rectangle();
			sr.draw(); 
			// output shape < cos override draw() , we just look at the type declared(Shape) >


		}
	}
}

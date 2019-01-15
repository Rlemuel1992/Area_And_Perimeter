using System;
using System.Linq;


namespace Area_And_Perimeter
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello, I'm here to calculate the area, perimeter and volume of your room! \n" +
				"Please input the length, width, and height IN FEET of the room you wish to have calculated.\n" +
				"if any of the measurements aren't numerical, they will not calculate properly.\n\n");
			double length = 0;
			double width = 0;
			double height = 0;



			Console.WriteLine("\n Please input your length then hit enter \n");
			double.TryParse(Console.ReadLine(), out length);

			Console.WriteLine("\n Now input your width then hit enter \n");
			double.TryParse(Console.ReadLine(), out width);

			Console.WriteLine("\n Finally let's do the height then hit enter \n");
			double.TryParse(Console.ReadLine(), out height);
		



			double area = length * width;
			double perimeter = 2 * length + 2 * width;
			double volume = length * width * height;

			Console.WriteLine("\n\n So the area of that room would be " + area + " sq ft \n" +
							"the perimeter would be " + perimeter + " sq ft. \n" +
							 "and your volume is " + volume + " feet.\n\n");

			Console.WriteLine("\n\nWould you like to measure another room out? Please type in Y or N");
			string answer = Console.ReadLine();

			var yes = new[] {"Y", "y", "Yes", "yes", "Ya", "ya", "sure"};
			var no = new[] { "N", "n", "No", "no", "NO", "Nah", "nO", "noty" };

			if (yes.Contains(answer))
			{
				Main();
			}

			else if (no.Contains(answer))
			{
				System.Environment.Exit(1);
			}

			else {
				Console.WriteLine("/nI couldn't understand, I'll start you from the beginning/n/n");
				Main();
					}





			}
	}
}

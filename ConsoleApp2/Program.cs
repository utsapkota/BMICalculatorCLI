using System;
using System.Linq.Expressions;
/**
* @author utsapkota
*
* @date - 13/10/2020 17:35
*/
namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			float height;
			float weight;
			float bmi;
			string check;

			Console.WriteLine();
			Console.WriteLine("Enter Your Height in Meter");
			height = float.Parse(Console.ReadLine());
			Console.WriteLine("Your height : {0} {1} ", Math.Round(height, 2), "Meter");
			Console.WriteLine();
			Console.WriteLine("Enter Your Weight in KG");
			weight = Single.Parse(Console.ReadLine());
			Console.WriteLine("Your weight : {0} {1} ", Math.Round(weight, 1), "KG");
			Console.WriteLine();
			Console.WriteLine("Enter m for man and w for woman");
			Console.WriteLine();
			check = Console.ReadLine();
			if (check == "w")
			{
				Console.WriteLine();
				Console.WriteLine("You are a Woman");
				Console.WriteLine();
				bmi = weight / (height * height);
				Console.WriteLine("=======================================");
				Console.WriteLine("Your BMI is : {0} ", Math.Round(bmi, 1));
				Console.WriteLine();
				if (bmi < 17.5)
					Console.WriteLine("You have anorexia.");
				if (bmi >= 17.5 && bmi <=19.1)
					Console.WriteLine("You are underweight.");
				else if (bmi >= 19.1 && bmi <= 25.8)
					Console.WriteLine("You are in normal range.");
				else if (bmi >= 25.8 && bmi <= 27.3)
					Console.WriteLine("You are marginally overweight.");
				else if (bmi >= 27.3 && bmi <= 32.3)
					Console.WriteLine("You are overweight.");
				else if (bmi > 32.3)
					Console.WriteLine("You are very overweight/obese.");
				else if (bmi >= 35 && bmi <= 40)
					Console.WriteLine("You are severely obese.");
				else if (bmi >= 40 && bmi <= 50)
					Console.WriteLine("You are morbidly obese.");
				else if (bmi >= 50 && bmi <= 60)
					Console.WriteLine("You are super obese.");
				Console.Write("=======================================");
				Console.WriteLine();

			}
			else if (check == "m")
			{
				Console.WriteLine();
				Console.WriteLine("You are a Man");
				Console.WriteLine();
				bmi = weight / (height * height);
				Console.WriteLine("=======================================");
				Console.WriteLine("Your BMI is : {0} ", Math.Round(bmi, 1));
				Console.WriteLine();
				if (bmi < 17.5)
					Console.WriteLine("You have anorexia.");
				if (bmi >= 17.5 && bmi <= 19.1)
					Console.WriteLine("You are underweight.");
				else if (bmi >= 19.1 && bmi <= 25.8)
					Console.WriteLine("You are in normal range.");
				else if (bmi >= 25.8 && bmi <= 27.3)
					Console.WriteLine("You are marginally overweight.");
				else if (bmi >= 27.3 && bmi <= 32.3)
					Console.WriteLine("You are overweight.");
				else if (bmi > 32.3)
					Console.WriteLine("You are very overweight/obese.");
				else if (bmi >= 35 && bmi <= 40)
					Console.WriteLine("You are severely obese.");
				else if (bmi >= 40 && bmi <= 50)
					Console.WriteLine("You are morbidly obese.");
				else if (bmi >= 50 && bmi <= 60)
					Console.WriteLine("You are super obese.");
				Console.Write("=======================================");
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Unrecognized");
				Console.ReadLine();
			}

		}
    }
}

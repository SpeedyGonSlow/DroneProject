using System;
using System.Diagnostics;

namespace DroneProject
{
	class Program
	{
		static int Main(string[] args)
		{
			const int cornfieldsize = 1073741824; // Math.Pow(2,30)
			int xy = (int)Math.Sqrt(cornfieldsize); 

			// Create cornfieldArray 
			int[,] cornfieldArray = new int[xy, xy];

			//	Test cases
			//	268419078
			//	268451837
			//	1073709032
			//	1073709057
			//	1073709087
			//	1073741824

			Console.WriteLine("Please enter the Drone fly time in seconds...");

			int flytime;

			while (!int.TryParse(Console.ReadLine(), out flytime))
			{
				Console.WriteLine("Invalid input! Please enter a number value... ");
			}

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			int counter = 1;

			for (int i = 0; i <= cornfieldArray.Length; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 0; j <= i; j++)
					{
						cornfieldArray[i, j] = counter;
						
						if (counter == flytime)
						{
							stopWatch.Stop();
							TimeSpan timespan = stopWatch.Elapsed;
							Console.WriteLine(ToString(i, j, timespan));
							_ = Console.ReadKey();
							return 0;
						}
						counter++;
					}

					for (int j = i - 1; j >= 0; j--)
					{
						cornfieldArray[j, i] = counter;

						if (counter == flytime)
						{
							stopWatch.Stop();
							TimeSpan timespan = stopWatch.Elapsed;
							Console.WriteLine(ToString(j, i, timespan));
							_ = Console.ReadKey();
							return 0;
						}
						counter++;
					}
				}

				if (i % 2 != 0)
				{
					for (int j = 0; j <= i; j++)
					{
						cornfieldArray[j, i] = counter;

						if (counter == flytime)
						{
							stopWatch.Stop();
							TimeSpan timespan = stopWatch.Elapsed;
							Console.WriteLine(ToString(j, i, timespan));
							_ = Console.ReadKey();
							return 0;
						}
						counter++;
					}

					for (int j = i - 1; j >= 0; j--)
					{
						cornfieldArray[i, j] = counter;

						if (counter == flytime)
						{
							stopWatch.Stop();
							TimeSpan timespan = stopWatch.Elapsed;
							Console.WriteLine(ToString(i, j, timespan));
							_ = Console.ReadKey();
							return 0;
						}
						counter++;
					}
				}
			}
			return 1;
		}

		static private string ToString(int x, int y, TimeSpan timespan)
		{
			return "X = " + (x + 1) + ", Y = " + (y + 1) + " - Execution Time = " + (timespan.TotalSeconds > 1 ? timespan.TotalSeconds + " seconds" : timespan.TotalMilliseconds + " milliseconds");
		}
	}
}
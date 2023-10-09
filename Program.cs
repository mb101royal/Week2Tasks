namespace Week2Tasks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Task 1: Ededin sade ve ya murekkeb olmasini yoxlamaq:
			/*Console.WriteLine("Eded daxil edin:");
            int myNum = Convert.ToInt32(Console.ReadLine());
			bool isPrime = true;

			for (int iter = 2; iter <= myNum-1; iter++)
			{
				if (myNum % iter == 0)
				{
                    Console.WriteLine("Daxil etdiyiniz eded(" + myNum + ") murekkebdir.");
					isPrime = false; break;
                }
			}
			if (myNum < 2)
			{
				isPrime = false;
				Console.WriteLine("Daxil etdiyiniz eded(" + myNum + ") ne murekkeb, ne de sadedir.");
			}
			if (isPrime) Console.WriteLine("Daxil etdiyiniz eded(" + myNum + ") sadedir.");*/

			// Task 2: Verilen ededin 2-nin quvveti olub olmamasini yoxlamaq:
			/*Console.WriteLine("Eded daxil edin:");
			int userNum = Convert.ToInt32(Console.ReadLine());
			
			if (userNum <= 0) Console.WriteLine("Xeta, musbet eded daxil edin.");
			else
			{
				bool isPower = true;
				int powerTimes = 0, temp = userNum;

				while (temp > 1)
				{
					if (temp % 2 != 0)
					{
                        isPower = false; break;
					}
					powerTimes++;
					temp /= 2;
				}
				if (isPower) Console.WriteLine("Eded 2-nin quvvetidir(2 uzeri " + powerTimes + ").");
				else Console.WriteLine("Eded 2-nin quvveti deyil.");
			}*/

			// Task 3: Ededin mertebelerinin sayini tapmaq:
			/*Console.WriteLine("Eded daxil edin:");
			int givenNum = Convert.ToInt32(Console.ReadLine()); // 21314

			if (givenNum <= 0) Console.WriteLine("Sifirdan boyuk eded daxil edin.");
			else
			{
				int floor = 1;

				for (int i = 10; i <= givenNum;)
				{
					givenNum /= 10;
					floor++;
				}
				Console.WriteLine("Daxil olunan ededde "+ floor +" mertebe var.");
			}*/
        }
	}
}
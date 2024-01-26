using System;
using System.ComponentModel.Design;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10, expo = 10;
            double etoomfoolery = 8e3;
            int coolnum = 69, coolnum2 = 420;
            string favperson = "Ryan Reynolds";
            double pie = 3.14159;
            char letter = 'a';
            bool doiloveryanreynolds = true;
         
            Console.WriteLine("Hello World!");
            Console.WriteLine("I like men");
            Console.WriteLine("I really like men");
            Console.WriteLine(3 * 3 / 3);
            Console.WriteLine(2423432);
            Console.Write("the world is ");
            Console.Write("not the best place to live in\n");
            // guys 
            /* cool
             * stuff */
            Console.WriteLine(coolnum);
            Console.WriteLine(favperson);
            Console.WriteLine(pie);
            Console.WriteLine(letter);
            Console.WriteLine(doiloveryanreynolds);
            Console.WriteLine("I really like " + favperson);
            Console.WriteLine(favperson + coolnum);
            Console.WriteLine(coolnum * coolnum2);
            Console.WriteLine("10^10 = " + Math.Pow(num, expo));
            Console.WriteLine(etoomfoolery);
            Console.WriteLine("What time is it?(>18,18,<18");
            int? time = Convert.ToInt32(Console.ReadLine());
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else if (time == 18)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Good night");
            }
            Console.WriteLine("What day is it?");
            int? day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("No clue which one that is");
                    break;
            }
            Console.WriteLine("Input 5");
            int? loop = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Invalid Input");
                loop++;
            }

            while (loop == 5);

            for (int i = 1; i <=2 ; ++i)
            {
                Console.WriteLine("Outer: " + i);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }
            string[] cars = { "Lambo", "Ferrari", "Nissan", "Toyota" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            string[] people = { "me", "du", "wir", "us" };
            for (int i = 0;i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

        }

    }
}



       
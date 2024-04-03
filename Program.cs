using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogAgeOne = 6.5;
            double dogAgeTwo = 8.5;
            int dogAgeThree = Convert.ToInt32(dogAgeOne);
            int dogAgeFour = Convert.ToInt32(dogAgeTwo);

            int gotchaDayOne = 5;
            int gotchaDayTwo = 4;
            double gotchaDayThree = Convert.ToDouble(gotchaDayOne) + .5; //must add the decimal places onto the end of the conversion if converting from int to double
            double gotchaDayFour = Convert.ToDouble(gotchaDayTwo) + .15;

            Console.WriteLine(dogAgeThree);
            Console.ReadKey();
            Console.WriteLine(dogAgeFour);
            Console.ReadKey();
            Console.WriteLine(gotchaDayThree);
            Console.ReadKey();
            Console.WriteLine(gotchaDayFour);
            Console.ReadKey();
            Console.WriteLine(gotchaDayTwo.GetType());
            Console.Beep();
        }
    }
}

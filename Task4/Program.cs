using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fReady = 1;
            int factorFinish = Factorial(fReady);
        }
        static int Factorial(int fReady)
        {
            int factorFinish = 0;
            string number;
            Console.WriteLine("Введите число n");
            number = Console.ReadLine();
            int number1 = Convert.ToInt32(number);

            for (int i = 0; i< number1; i++)
            {
                fReady = fReady * (i + 1);
            }
            Console.WriteLine(fReady);
            return factorFinish;
        }
    }
}

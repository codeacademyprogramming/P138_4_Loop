using System;

namespace _19012923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 5;

            var hasil = 1;


            for (int i = 1; i < 5; i++)
            {
                hasil *= num;
            }

            Console.WriteLine(hasil);



            var num1 = 5;
            var sum = 0;

            while (num1 < 10)
            {
                sum += num1;
                num1++;
            }


            int number = 45;


            int x = 1;
            int count = 0;

            while (x < number)
            {
                if (x % 5 == 0)
                {
                    count++;
                }

                x++;
            }

            Console.WriteLine(count);





            int A=20;
            int B=30;


            var sumOfNumbers = 0;

            while (A < B)
            {

                if (A % 3 == 0)
                {
                    sumOfNumbers += A;
                }

                A++;
            }

            Console.WriteLine(sumOfNumbers);

            for(int i=A; i < B; i++)
            {
                if (i % 3 == 0)
                {
                    sumOfNumbers += i;
                }
            }

        }
    }
}

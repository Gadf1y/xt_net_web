using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    class Program
    {


        /// <summary>
        /// Sequence
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static String Sequence(int N)
        {
            String str = "";
            for (int i = 1; i < N + 1; i++)
            {
                if (i != N)
                {
                    str=str+(i+",");
                }
                else
                {
                    str = str + (i);
                }
            }
            return str;
        }

/// <summary>
/// Prime number
/// </summary>
/// <param name="N"></param>
/// <returns></returns>

        static Boolean Simple(int N)
        {
            if (N == 0 || N == 1)
            {
                Console.WriteLine(N + " is not prime");
                Console.ReadLine();
                return false;
            }
            else
            {
                for (int a = 2; a <= N / 2; a++)
                {
                    if (N % a == 0)
                    {
                        Console.WriteLine(N + " is not prime");
                        return false;

                    }

                }
                Console.WriteLine(N + " is prime");
                Console.ReadLine();
                return true;
            }
        }







        /// <summary>
        /// Starsquare
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Square(int N)
        {
            if (N % 2 == 0)
            {
                Console.WriteLine("Введённые данные не являются нечетным числом");
            }
            else
            {
                for (int i = N; i > 0; i--)
                {
                    for (int j = N; j > 0; j--)
                    {
                        if ((j == N / 2 + 1) & (i == N / 2 + 1))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            if (j == 1) { Console.WriteLine("*"); }
                            else Console.Write("*");
                        }
                    }

                }
            }
        }





        /// <summary>
        /// Array
        /// </summary>
        /// <param name="args"></param>

        public static void Array()
        {
            Console.Write("Размер массива: ");
            int Size = Convert.ToInt32(Console.ReadLine());

        }





























        static void Main(string[] args)
        {
       //Console.WriteLine(Sequence(5));
      //Console.WriteLine(Simple(7));
      Square(5);
       Console.ReadKey();
        



        }
    }
}

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
            Console.Write("Ввести размер массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
                int[][] arrays = new int[x][];
                for (int i = 0; i < x; i++)
                {
                    Console.Write("Ввести количество элементов: ", i + 1);
                    int y = Convert.ToInt32(Console.ReadLine());
                    arrays[i] = new int[y];
                }
                for (int i = 0; i < arrays.Length; i++)
                {
                    for (int j = 0; j < arrays[i].Length; j++)
                        arrays[i][j] = rand.Next(0, 100);
                }
                Console.WriteLine();
                Console.WriteLine("Несортированный массив ");
                WriteArray(arrays);
                SortArray(arrays);
                Console.WriteLine("Сортированый массив: ");
                WriteArray(arrays);
            }
            public static void WriteArray(int[][] arrays)
            {

                Console.Write("{");
                foreach (int[] i in arrays)
                {
                    Console.Write("{");
                    foreach (int j in i)
                    {
                        Console.Write(j.ToString() + ",");
                    }
                    Console.Write("},");
                }
                Console.WriteLine("}\n");
            }
            public static void SortArray(int[][] arrays)
            {
                int i = 0;
                foreach (int[] arr in arrays)
                    i += arr.Length;
                int[] temp = new int[i];
                i = 0;
                for (int n = 0; n < arrays.Length; n++)
                {
                    for (int m = 0; m < arrays[n].Length; m++)
                    {
                        temp[i] = arrays[n][m];
                        i++;
                    }
                }
                i = 0;
                System.Array.Sort(temp);
                for (int n = 0; n < arrays.Length; n++)
                {
                    for (int m = 0; m < arrays[n].Length; m++)
                    {
                        arrays[n][m] = temp[i];
                        i++;
                    }
                }
            }
       





























            static void Main(string[] args)
        {
       //Console.WriteLine(Sequence(5));
      //Console.WriteLine(Simple(7));
     // Square(5);
     //Console.ReadKey();
            Array();
            Console.ReadLine();
        



        }
    }
}

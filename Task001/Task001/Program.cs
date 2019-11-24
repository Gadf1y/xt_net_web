using System;

namespace Task001
{
    class Program

    {

        public static void Rectangle()
        {
            Console.WriteLine("Enter A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a <= 0 || b <= 0))
            {
                Console.WriteLine("Incorrect enter");
                Rectangle();
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++) { Console.Write("*"); }
                    Console.WriteLine();
                }
            }






        }

        /// <summary>
        /// Triangle
        /// </summary>

        public static void Triangle()
        {
            Console.WriteLine("Enter number:");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= h; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j < i) {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void IsoscelesTriangle()
        {
            Console.WriteLine("Enter number:");
            int h = Convert.ToInt32(Console.ReadLine());
            GetIsoscelesTriangle(h);


            Console.ReadLine();
        }


        public static void XmasTree()
        {
            Console.WriteLine("Enter number:");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k <= h; k++)
            {
                for (int i = 1; i <= k; i++)
                {
                    // Write spaces
                    for (int j = 1; j <= (h - i); j++)
                    { Console.Write(" "); }
                    //Write stars increase
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    //Write stars decrease
                    for (int j = (i - 1); j >= 1; j--)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }

        }


        /// <summary>
        /// Сделать Гет Триангл
        /// </summary>
        /// <param name="args"></param>
        /// 


        public static void GetIsoscelesTriangle(int side) {



            for (int i = 1; i <= side; i++)
            {
                // Write spaces
                for (int j = 1; j <= (side - i); j++)
                { Console.Write(" "); }
                //Write stars increase
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                //Write stars decrease
                for (int j = (i - 1); j >= 1; j--)
                    Console.Write("*");
                Console.WriteLine();
            }


        }




        /// <summary>
        /// 1.5 Sum of numbers
        /// </summary>
        /// <param name="args"></param>
        /// 

        public static void SumOfNumbers(){
            int a = 1000;
            int sum = 0;
        for(int i=0; i<a; i++){
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }





        static void Main(string[] args)
        {
            //IsoscelesTriangle();
            //Rectangle();
            //Triangle();
            //XmasTree();
            //GetIsoscelesTriangle(5);
            //SumOfNumbers();

            Console.ReadKey();
        }

    }
}

using System;

namespace Lesson3
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine((DayOfWeek.Friday));
            //Message();
            //Message("Hello");
            //Console.WriteLine(Plus(b:3, a:5.0));
            //int c = Plus(3, 4);

            //int a = 10;
            //int b;
            //Y(ref a);
            //Console.WriteLine($"До вызова метода: {a}");
            //Minus(a, out b);
            //Console.WriteLine($"После вызова метода: {a}");

            //Console.WriteLine(b);

            //int[] G = { 3, 6, 5, 45, 8, 3, -1 };
            //int[] H = { -5, -8 };
            //Mas(G);
            //Console.WriteLine();
            //Mas(H);
            //Console.WriteLine();
            //Mas1(3, 2, 2, 2, 2, 2, 2, 2, 2);
            Console.ReadKey();

        }

        public static void Message() => Console.WriteLine("Hello world");

        public static void Message(string s) => Console.WriteLine(s);
        public static int Plus(int a, int b)
        {
            Console.WriteLine("kjg");
            inside();
            return a + b;
            static void inside()
            {
                Console.WriteLine("hdfdsb");
            }
            
        }

        public static double Plus(double a, int b = 7) => b + a;

        public static int Minus(int a, out int b)
        {
            Console.WriteLine($"Во время вызова метода: {a}");
            b = a + 1;
            return b;
        }

        public static int Y(ref int a)
        {
            Plus(1, 1);
            1 + 2;
            return a * 10;
        }
        public static void Mas(int[] F)
        {
            for(int i=0;i<F.Length;i++)
                Console.WriteLine(F[i]);
        }

        public static void Mas1(int v, params int[] F)
        {
            for (int i = 0; i < F.Length; i++)
                Console.WriteLine(F[i]);
        }
        //модификатор_доступа тип_возвращаемого_значения Имя_метода(аргументы)
        //{
        //    тело_метода;
        //}
    }
}

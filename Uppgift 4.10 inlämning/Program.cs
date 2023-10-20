using System;
namespace inlämning_4._10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många X vill du ha per grupp?");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O vill du ha per grupp?");
            int O = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-grupper per rad?");
            int Orad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader vill du ha?");
            int rader = int.Parse(Console.ReadLine());

           for(int i = 0; i < rader; i++)
            {
                for(int j = 0; j < Orad; j++)
                {
                    for (int k = 0; k < X; k++)
                    {
                        Console.Write("X");
                    }
                    Console.Write("-");
                    for(int q = 0; q < O; q++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }
                for (int y = 0; y < X; y++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
           Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;

namespace github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abu graib");

            //add
            int[,] matrica = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrica[i, j] = 1;
                }
            }
            //priunt
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrica[i, j]);
                    Console.Write("   ");
                }
            }
        }
    }
}

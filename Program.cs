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
                    matrica[i, j] = 0;
                }
            }
            matrica[0, 0] = 9;
            //pecatenje(matrica);
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    if (matrica[i,j]==9)
                    {
                        matrica[i, 0]++;
                        matrica[i, 1]++;
                        matrica[i, 2]++;
                        matrica[i, 3]++;
                        matrica[i, 4]++;
                        matrica[i, 5]++;
                        matrica[i, 6]++;
                        matrica[i, 7]++;

                        matrica[0, j]++;
                        matrica[1, j]++;
                        matrica[2, j]++;
                        matrica[3, j]++;
                        matrica[4, j]++;
                        matrica[5, j]++;
                        matrica[6, j]++;
                        matrica[7, j]++;
                        matrica[i, j]--;
                        matrica[i, j]--;



                    }
                }
            }
            pecatenje(matrica);
        }
        
        static void pecatenje(int[,] matrica)
        {
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

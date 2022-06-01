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
            //matrica[0, 0] = 9;
            matrica[7, 6] = 9;
            //pecatenje(matrica);
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    if (matrica[i,j]==9)
                    {
                        //row
                        for (int a = 0; a < 8; a++)
                        {
                            matrica[i, a]++;
                        }
                        //column
                        for (int b = 0; b < 8; b++)
                        {
                            matrica[b, j]++;
                        }
                        // + +
                        for (int k = i, l=j; k < 8 && l<8; k++, l++)
                        {
                            if (k<8 && l<8)
                            {
                                matrica[k, l]++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // + -
                        for (int k = i, l = j; k < 8 && l >= 0; k++, l--)
                        {
                            if (k < 8 && l >= 0)
                            {
                                matrica[k, l]++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // - -
                        for (int k = i, l = j; k >= 0 && l >= 0; k--, l--)
                        {
                            if (k >= 0 && l >= 0)
                            {
                                matrica[k, l]++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // - +
                        for (int k = i, l = j; k >= 0 && l < 8; k--, l++)
                        {
                            if (k >= 0 && l < 8)
                            {
                                matrica[k, l]++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // normaliziranje
                        matrica[i, j] = matrica[i, j] - 6;
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

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
            int[,] prazna = new int[8, 8];
            //polnenje so 0
            void polnenje(int[,] matrica) {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        matrica[i, j] = 0;
                    }
                }
            }
            polnenje(matrica);
            polnenje(prazna);
            //pecatenje(matrica);
            //matrica[0, 0] = 9;
            //matrica[7, 6] = 9;
            //matrica[4, 4] = 9;
            //attack(matrica);
            //pecatenje(matrica);
            int z = 0, x = 0;
            //queen attack
            void attack(int[,] matrica) {
                for (int i = 0; i < 8; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {
                        if (matrica[i, j] == 9)
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
                            for (int k = i, l = j; k < 8 && l < 8; k++, l++)
                            {
                                if (k < 8 && l < 8)
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
            }

            //8 queen shuffle
            for (; ; )
            {
                polnenje(matrica);
                
                if (z <= 7 && x < 7 )
                {
                    matrica[z, x] = 9;
                    attack(matrica);
                    pecatenje(matrica);
                    Console.WriteLine("\n\n");
                    x++;
                }
                else if (z<=7 && x==7)
                {
                    matrica[z, x] = 9;
                    attack(matrica);
                    pecatenje(matrica);
                    Console.WriteLine("\n\n");
                    z++;
                    x = 0;
                }
                else if (z==7 && x==7)
                {
                    break;
                }
                else
                {
                    break;
                }

            }



            //pecatenje(matrica);
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

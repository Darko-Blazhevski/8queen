using System;
using System.Collections.Generic;

namespace github
{
    class Program
    {
        static void Main(string[] args)
        {
    
            int[,] matrica = new int[8, 8];

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
           
            int z = 0, x = 0,brojac = 1;

            void attack(int[,] matrica) {
                for (int i = 0; i < 8; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {
                        if (matrica[i, j] >= 9)
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

            for (int i0 = 0; i0 <= 7; i0++)
                {
                    for (int i1 = 0; i1 <= 7; i1++)
                    {
                        for (int i2 = 0; i2 <= 7; i2++)
                        {
                            for (int i3 = 0; i3 <= 7; i3++)
                            {
                                for (int i4 = 0; i4 <= 7; i4++)
                                {
                                    for (int i5 = 0; i5 <= 7; i5++)
                                    {
                                        for (int i6 = 0; i6 <= 7; i6++)
                                        {
                                            for (int i7 = 0; i7 <=7; i7++)
                                            {
                                                polnenje(matrica);
                                                matrica[0, i0] = 9;
                                                matrica[1, i1] = 9;
                                                matrica[2, i2] = 9;
                                                matrica[3, i3] = 9;
                                                matrica[4, i4] = 9;
                                                matrica[5, i5] = 9;
                                                matrica[6, i6] = 9;
                                                matrica[7, i7] = 9;
                                                attack(matrica);
                                                if (proverka(matrica))
                                                {
                                                    pecatenje(matrica);
                                                    Console.WriteLine("\n\n");
                                                    Console.WriteLine(brojac);
                                                    brojac++;
                                                    Console.WriteLine("\n\n");
                                                }
                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            Console.WriteLine("KRAJ!!");
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
        static bool proverka(int[,] matrica)
        {
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (matrica[i, j] > 9)
                    {
                        return false;
                    }
                   
                }
            }
            return true;
        }
    }
}

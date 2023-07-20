using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task22
    {
        public void Start()
        {
            int currNum = 0;
            int repeatNum = 0;
            int repeatedCol = 0;
            
            int currRepaet = 0;
            int maxRepeatNum = 0;

            int[,] array = new int[6, 5];
            // {
            //     {6, 6, 6, 6, 6},
            //     {7, 4, 9, 9, 4},
            //     {3, 5, 6, 9, 2},
            //     {1, 8, 4, 7, 7},
            //     {5, 0, 9, 7, 6},
            //     {0, 4, 7, 5, 9} };
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j  = 0; j  < array.GetLength(1); j ++)
                {
                    Random rand = new Random();
                    int randNum = rand.Next(0, 10);
                    array[i, j] = randNum;
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
                
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j  < array.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        currNum = array[i, j];
                        currRepaet = 1;
                    }

                    if (array[i, j] == currNum && j != 0)
                    {
                        currRepaet++;
                    }
                    if (currRepaet > maxRepeatNum)
                    {
                        maxRepeatNum = currRepaet;
                        repeatNum = currNum;
                        repeatedCol = i;
                    }
                    else
                    {
                        currRepaet = 1;
                        currNum = array[i, j];
                    }
                }
            }
            Console.WriteLine("The collumn is: ");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write(array[repeatedCol, i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number is: " + repeatNum);
            Console.WriteLine("Repeat number is: " + maxRepeatNum);
            
        }
    }
}
using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task19
    {
        public void Start()
        {
            int[,] array = new int[10, 10];
            string arrayCol = String.Empty;
            
            int maxNum = 0;
            int[] indexMaxNum = new int[2];
            
            Console.WriteLine("Old matrix:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Random rand = new Random();
                    int randNum = rand.Next(10, 100);
                    
                    array[i, j] = randNum;
                    arrayCol += Convert.ToString(array[i, j]) + " ";
                    
                    if (array[i,j] > maxNum)
                    {
                        maxNum = array[i, j];
                        indexMaxNum[0] = i;
                        indexMaxNum[1] = j;
                    }
                }
                Console.WriteLine(arrayCol);
                arrayCol = String.Empty;
            }
            array[indexMaxNum[0], indexMaxNum[1]] = 0;
            
            Console.WriteLine("New matrix:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    arrayCol += Convert.ToString(array[i, j]) + " ";
                }
                
                Console.WriteLine(arrayCol);
                arrayCol = String.Empty;
            }
        }
    }
}
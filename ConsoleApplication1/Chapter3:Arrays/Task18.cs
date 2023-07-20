using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task18
    {
        public void Start()
        {
            int[,] array = new int[2, 5] { 
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 } };
            
            int firstNumSum = 1;
            int secondColSum = 0;
            
            string arrayCol = String.Empty;
            
            Console.WriteLine(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayCol += Convert.ToString(array[i, j]) + " ";
                    if (j == 0)
                    {
                        firstNumSum *= array[i, j];
                    }

                    if (i >= 1)
                    {
                        secondColSum += array[i, j];
                    }
                }
                Console.WriteLine(arrayCol);
                arrayCol = String.Empty;
            }
            
            
            Console.WriteLine(firstNumSum);
            Console.WriteLine(secondColSum);
        }
    }
}
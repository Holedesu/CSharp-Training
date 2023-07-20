using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task23
    {
        public void Start()
        {
            int temp = 0;
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Random rand = new Random();
                array[i] = rand.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }

                Console.Write(array[i] + " ");
            }


        }
    }
}
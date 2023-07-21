using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task20
    {
        public void Start()
        {
            int[] array = new int[30];
            int localmax = 0; 
            
            for (int i = 0; i < array.Length; i++)
            {
                Random rand = new Random(); 
                int randNum = rand.Next(0, 101);
                array[i] = randNum;
                
                Console.Write(Convert.ToString(array[i]) + " ");
            }
            
            Console.WriteLine("\n");
            if (array[0] > array[1])
            {
                localmax = array[0];
                Console.WriteLine($"Local maximum is {localmax} at index {0}");
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    localmax = array[i];
                    Console.WriteLine($"Local maximum is {localmax} at index {i}");
                }

                if (array[i + 1] < array[i])
                {
                    i++;
                }
            }
            
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                localmax = array[array.Length - 1];
                Console.WriteLine($"Local maximum is {localmax} at index {array.Length - 1}");
            }
        }
    }
}
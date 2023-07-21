using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task25
    {
        public void Start()
        {
            int[] array = new int[10];

            Console.WriteLine("type number from 1 to 9: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            int[] arraySlice = new int[userInput];
            int[] leastArray = new int [array.Length - arraySlice.Length];

            int arrayCounter = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = i;
                Console.Write(array[i] + " ");
            }
            
            Console.WriteLine();
            for (int i = arraySlice.Length; i < array.Length; i++)
            {
                leastArray[arrayCounter] = array[i];
                Console.Write(array[i] + " ");
                arrayCounter++;
            }
            
            for (int i = 0; i < arraySlice.Length; i++)
            {
                arraySlice[i] = array[i];
                Console.Write(array[i] + " ");
            }

        }
    }
}
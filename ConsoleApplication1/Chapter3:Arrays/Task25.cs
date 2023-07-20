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
            
            int[] arraySlice = new int[userInput - 1];
            int[] leastArray = new int [(array.Length - 1) - arraySlice.Length];

            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = i;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arraySlice.Length; i++)
            {
                arraySlice[i] = array[i];
                Console.Write(array[i] + " ");
            }
            for (int i = arraySlice.Length; i < leastArray.Length; i++)
            {
                leastArray[i] = array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
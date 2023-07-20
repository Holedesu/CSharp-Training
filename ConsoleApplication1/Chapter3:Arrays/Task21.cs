using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task21
    {
        public void Start()
        {
            int[] array = new int[1];
            bool flag = true;
            int sum = 0;
            int index = 0;
            
            Console.WriteLine(" Type Int to add it to array\n Type exit to exit\n Type sum to get sum of all numbers");
            while (flag)
            {
                string userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    flag = false;
                }
                else if (userInput == "sum")
                {
                    foreach (int number in array)
                    {
                        sum += number;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    int[] extendedArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                    {
                        extendedArray[i] = array[i];
                    }
                    extendedArray[extendedArray.Length - 1] = Convert.ToInt32(userInput);
                    array = extendedArray;
                }
                
            }
        }
    }
}
using System;

namespace ConsoleApplication1.Chapter4_Functions
{
    public class Task30
    {
        public void Start()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Shuffle(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void Shuffle(int[] array)
        {
            Random rand = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = rand.Next(i, array.Length);
                int tempValue = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = tempValue;
            }
        }
    }
}
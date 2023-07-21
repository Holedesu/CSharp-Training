using System;

namespace ConsoleApplication1.Chapter3_Arrays
{
    public class Task24
    {
        public void Start()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            
            Console.WriteLine(sentence);
            
            string[] wordArray = sentence.Split(' ');

            foreach (string word in wordArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter5_Collections
{
    public class Task35
    {
        public void Start()
        {
            string[] stringArray1 = new[] { "1", "2", "1" };
            string[] stringArray2 = new[] { "3", "2" };
            List<string> stringList = new List<string>();

            for (int i = 0; i < stringArray1.Length; i++)
            {
                if (!stringList.Contains(stringArray1[i]))
                { 
                    stringList.Add(stringArray1[i]);
                }
                
            }

            for (int i = 0; i < stringArray2.Length; i++)
            {
                if (!stringList.Contains(stringArray2[i]))
                {
                    stringList.Add(stringArray2[i]);
                }
            }

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
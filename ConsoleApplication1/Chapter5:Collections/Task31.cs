using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter5_Collections
{
    public class Task31
    {
        public void Start()
        {
            Dictionary<string, string> wordMeaning = new Dictionary<string, string>();
            wordMeaning.Add("Телеграм", "Соцсеть для общения");
            wordMeaning.Add("Iphone", "Телефон компании Apple");
            wordMeaning.Add("YouTube", "Видеохостинг");
            wordMeaning.Add("JBL", "Компания по производству звукового оборудования");

            bool cycleChecker = true;
            while (cycleChecker)
            {
                Console.WriteLine("Какое слово вам обьяснить? \n(на выбор: Телеграм, Iphone, YouTube, JBL)");
                string userAnswer = Convert.ToString(Console.ReadLine());
                if (wordMeaning.ContainsKey(userAnswer))
                {
                    Console.WriteLine(wordMeaning[userAnswer]);
                    cycleChecker = false;
                }
                else
                {
                    Console.WriteLine("Данного слова нет в нашем словаре, попробуйте снова!");
                }
            }
        }
    }
}
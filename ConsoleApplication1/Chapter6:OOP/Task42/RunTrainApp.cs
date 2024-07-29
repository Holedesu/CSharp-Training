using System;

namespace ConsoleApplication1.Chapter6_OOP.Task42
{
    public class RunTrainApp
    {
        public static void Run()
        {
            bool cycleSwitcher = true;
            
            while(cycleSwitcher)
            {
                Console.WriteLine("Запустить поезд? Да/Нет");
                string playerAnswer = Convert.ToString(Console.ReadLine());

                switch(playerAnswer)
                {
                    default:
                        Console.WriteLine("Введен неверный символ");
                        break;
                    case "Да":
                        Console.WriteLine("Укажите откуда поедет поезд");
                        string userAnswer = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Укажите куда поедет поезд");
                        string userAnswer2 = Convert.ToString(Console.ReadLine());
                        CreateRoute route = new CreateRoute(userAnswer, userAnswer2);
                        Console.Clear();
                        
                        route.RouteInfo();
                        Console.WriteLine("Начинаем продажу билетов");
                        Console.ReadLine();
                        Travellers travellers = new Travellers();
                        Console.WriteLine("Продано");
                        Console.Clear();
                        
                        route.RouteInfo(travellers);
                        Console.WriteLine("Создаем состав");
                        Console.ReadLine();
                        Train train = new Train();
                        train.MakeComposition(travellers);
                        Console.WriteLine("Состав создан");
                        Console.ReadLine();
                        Console.Clear();
                        
                        route.RouteInfo(travellers, train);
                        Console.WriteLine("Поезд запущен");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "Нет":
                        cycleSwitcher = false; 
                        break;
                }
            }
        }
    }
}
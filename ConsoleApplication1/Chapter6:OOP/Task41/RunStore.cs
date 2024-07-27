using System;
using ConsoleApplication1.Chapter6_OOP.Task40;

namespace ConsoleApplication1.Chapter6_OOP.Task41
{
    public class RunStore
    {
        public static void Run()
        {
            StorePlayer player = new StorePlayer();
            Seller seller = new Seller();
            Item item = new Item("Хлеб");
            Item item2 = new Item("Молоко");
            Item item3 = new Item("Масло");
            Item item4 = new Item("Колбаса");
            
            seller.AddToCart(item);
            seller.AddToCart(item2);
            seller.AddToCart(item3);
            seller.AddToCart(item4);
            
            bool cycleSwitcher = true;
            
            while(cycleSwitcher)
            {
                Console.WriteLine("1. Купить товар\n2. Посмотреть купленное\n3. Посмотреть товары продавца\n4. Выход");
                string playerAnswer = Convert.ToString(Console.ReadLine());

                switch(playerAnswer)
                {
                    default:
                        Console.WriteLine("Введен неверный символ");
                        break;
                    case "1":
                        Console.WriteLine("Укажите товар");
                        string userAnswer = Convert.ToString(Console.ReadLine());

                        if (seller.checkExistence(userAnswer))
                        {
                            player.Buy(userAnswer);
                            seller.RemoveFromCart(userAnswer);
                        }
                        else
                        {
                            Console.WriteLine("Такого товара нет");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Посмотреть купленное");
                        player.ShowCart();
                        break;
                    case "3":
                        Console.WriteLine("Посмотреть товары продавца");
                        seller.ShowCart();
                        break;
                    case "4":
                        cycleSwitcher = false; 
                        break;
                }
            }
        }
    }
}
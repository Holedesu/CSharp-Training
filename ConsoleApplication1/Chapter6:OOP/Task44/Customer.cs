using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task44
{
    public class Customer
    {
        private List<Grocery> _groceries;
        private int _customerMoney;
        public Customer()
        {
            _groceries = new List<Grocery>();
        }

        public Customer(List<Grocery> groceries)
        {
            _groceries = new List<Grocery>();
            _customerMoney = GenerateMoney();
            
            foreach (var grocery in groceries)
            {
                _groceries.Add(grocery);
            }
            
        }

        public void DeleteRandomItem()
        {
            Random randomNum = new Random();
            _groceries.RemoveAt(randomNum.Next(0, _groceries.Count));
        }
        
        public bool IsEnoughMoney()
        {
            if (CountCartPrice() > _customerMoney)
            {
                return false;
            }

            return true;
        }
        
        public void ShowCart()
        {
            foreach (var grocery in _groceries)
            {
                Console.WriteLine($"{grocery.GroceryName} - {grocery.Price}");
            }
        }
        
        public void ShowMoney()
        {
            Console.WriteLine($"Money: {_customerMoney}");
        }
        
        private int GenerateMoney()
        {
            Random rand = new Random();
            return rand.Next(1, 500);
        }

        private int CountCartPrice()
        {
            int totalPrice = 0;
            foreach (var grocery in _groceries)
            {
                totalPrice += grocery.Price;
            }

            return totalPrice;
        }
    }
}
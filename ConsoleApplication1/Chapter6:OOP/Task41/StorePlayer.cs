using System;
using System.Collections.Generic;

using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task41
{
    public class StorePlayer
    {
        private List<Item> _cart;
        
        public StorePlayer()
        {
            _cart = new List<Item>();
        }
        
        public void AddToCart(Item item)
        {
            _cart.Add(item);
        }
        
        public void Buy(string item)
        {
            Item product = new Item(item);
            _cart.Add(product);
        }
        
        public void ShowCart()
        {
            foreach (var item in _cart)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
using System;
using System.Collections.Generic;
namespace ConsoleApplication1.Chapter6_OOP.Task41
{
    public class Seller
    {
        public List<Item> _cart;
        
        public Seller()
        {
            _cart = new List<Item>();
        }
        
        public void AddToCart(Item item)
        {
            _cart.Add(item);
        }
        
        public void RemoveFromCart(string item)
        {
            for(int i = 0; i < _cart.Count; i++)
            {
                if(_cart[i].ToString() == item)
                {
                    _cart.RemoveAt(i);
                }
            }
        }
        
        public void ShowCart()
        {
            foreach(var item in _cart)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
        public bool checkExistence(string item)
        {
            foreach(var product in _cart)
            {
                if(product.ToString() == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
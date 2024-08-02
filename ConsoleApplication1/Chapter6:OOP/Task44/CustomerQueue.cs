using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Chapter6_OOP.Task44
{
    public class CustomerQueue
    {
        private Queue<Customer> _customers;

        public CustomerQueue(int CustomersAmount)
        {
            _customers = new Queue<Customer>();
            
            for (int i = 0; i < CustomersAmount; i++)
            {
                _customers.Enqueue(GenerateCustomer());
            }
        }
        
        public CustomerQueue()
        {
            _customers = new Queue<Customer>();
            
            for (int i = 0; i < 10; i++)
            {
                _customers.Enqueue(GenerateCustomer());
            }
        }

        public int GetLength()
        {
            return _customers.Count;
        }
        
        public Customer Dequeue()
        {
            return _customers.Dequeue();
        }

        public void CheckPayable()
        {
            foreach (var customer in _customers.ToList())
            {
                Console.WriteLine("Customer is waiting for payment.");
                while (!customer.IsEnoughMoney())
                {
                    customer.ShowMoney();
                    Console.WriteLine();
                    customer.ShowCart();
                    Console.ReadLine();

                    if (!customer.IsEnoughMoney())
                    {
                        Console.WriteLine("Sorry, not enough money. Delete something from your cart.");
                        Console.ReadLine();
                        customer.DeleteRandomItem();
                    }
                }
                Console.WriteLine("Thank you for shopping with us! You bought:");
                customer.ShowCart();
                Console.ReadLine();
                Console.Clear();
                _customers.Dequeue();
            }
        }
        
        private Customer GenerateCustomer()
        {
            Random groceryAmount = new Random();
            
            List<Grocery> groceries = new List<Grocery>
            {
                new Grocery("Apple", 45),
                new Grocery("Milk", 60),
                new Grocery("Bread", 30),
                new Grocery("Cheese", 80),
                new Grocery("Eggs", 55),
                new Grocery("Chicken", 70),
                new Grocery("Butter", 40),
                new Grocery("Yogurt", 50),
                new Grocery("Orange Juice", 65),
                new Grocery("Banana", 35),
                new Grocery("Tomato", 20),
                new Grocery("Potato", 15),
                new Grocery("Onion", 25),
                new Grocery("Carrot", 30),
                new Grocery("Lettuce", 45),
                new Grocery("Cucumber", 20),
                new Grocery("Pepper", 35),
                new Grocery("Fish", 90),
                new Grocery("Beef", 95),
                new Grocery("Pork", 85),
                new Grocery("Pasta", 40),
                new Grocery("Rice", 35),
                new Grocery("Cereal", 50),
                new Grocery("Flour", 30),
                new Grocery("Sugar", 25),
                new Grocery("Salt", 10),
                new Grocery("Oil", 60),
                new Grocery("Vinegar", 40),
                new Grocery("Ketchup", 35),
                new Grocery("Mustard", 30)
            };

            List<Grocery> groceryList = new List<Grocery>();
            
            for (int i = 0; i < groceryAmount.Next(1, 10); i++)
            {
                groceryList.Add(groceries[groceryAmount.Next(0, groceries.Count)]);
            }
            return new Customer(groceryList);
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
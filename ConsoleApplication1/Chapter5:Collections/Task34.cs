using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter5_Collections
{
    public class Task34
    {
        private Dictionary<string, string> _employeeInfo = new Dictionary<string, string>();
        
        public void Start()
        {
            string userInput = String.Empty;
            bool exit = true;

            while (exit)
            {
                Console.WriteLine(
                    "1) добавить досье\n" +
                    "2) вывести все досье (в одну строку через “-” фио и должность с порядковым номером в начале)\n" +
                    "3) удалить досье (Массивы уменьшаются на один элемент. Нужны дополнительные проверки, чтобы не возникало ошибок)\n" +
                    "5) выход");
                
                userInput = Convert.ToString(Console.ReadLine());
                
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите ФИО через пробел");
                        string nameInput = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите должность");
                        string dutyInput = Convert.ToString(Console.ReadLine());
                        AddEmployee(nameInput, dutyInput);
                        continue;
                    case "2":
                        PrintEployeesInfo();
                        continue;
                    case "3":
                        Console.WriteLine("Введите ФИО того, чье досье вы хотите удалить");
                        string userForDelete = Convert.ToString(Console.ReadLine());
                        DeleteEmployeeInfo(userForDelete);
                        continue;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        continue;
                }
            }
        }

        private void AddEmployee(string name, string duty)
        {
            _employeeInfo.Add(name, duty);
        }
        
        private void PrintEployeesInfo()
        {
            foreach (var employee in _employeeInfo)
            {
                Console.WriteLine($"{employee.Key} - {employee.Value}");
            }
        }

        private void DeleteEmployeeInfo (string employeeName)
        {
            _employeeInfo.Remove(employeeName);
        }
    }
}
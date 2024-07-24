using System;
using System.Xml;

namespace ConsoleApplication1.Chapter4_Functions
{
    public class Task26
    {
        private string[,] _employeesName = new string[0, 3];
        private string[] _jobName = new string[0];
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
                    "4) поиск по фамилии\n" +
                    "5) выход");
                
                userInput = Convert.ToString(Console.ReadLine());
                
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите ФИО через пробел");
                        userInput = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите должность");
                        string dutyInput = Convert.ToString(Console.ReadLine());
                        AddEmployee(userInput, dutyInput);
                        continue;
                    case "2":
                        PrintEployeesInfo();
                        continue;
                    case "3":
                        Console.WriteLine("Введите индекс досье для удаления");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;
                        DeleteEmployeeInfo(index);
                        continue;
                    case "4":
                        Console.WriteLine("Введите фамилию искомого сотрудника");
                        string surname = Convert.ToString(Console.ReadLine());
                        SearchBySurname(surname);
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

        private void AddEmployee(string userInput, string duty)
        {
            string[] splittedUser = userInput.Split(' ');
            string userSurname = splittedUser[0];
            string userName = splittedUser[1];
            string userPatronymic = splittedUser[2];

            _employeesName = ArrayExtender(_employeesName);
            int UserArrayLength = _employeesName.GetLength(0) - 1;
            
            _employeesName[UserArrayLength, 0] = userName;
            _employeesName[UserArrayLength, 1] = userSurname;
            _employeesName[UserArrayLength, 2] = userPatronymic;

            _jobName = ArrayExtender(_jobName);
            int DutyArrayLength = _jobName.GetLength(0) - 1;
            _jobName[DutyArrayLength] = duty;


        }

        private string[,] ArrayExtender(string[,] currentArray)
        {
            int oldLength = currentArray.GetLength(0);
            string[,] newArray = new string[oldLength + 1, 3];
            
            for (int i = 0; i < oldLength; i++)
            {
                newArray[i, 0] = currentArray[i, 0];
                newArray[i, 1] = currentArray[i, 1];
                newArray[i, 2] = currentArray[i, 2];
            }

            return newArray;
        }
        
        private string[] ArrayExtender(string[] currentArray)
        {
            int oldLength = currentArray.GetLength(0);
            string[] newArray = new string[oldLength + 1];
            
            for (int i = 0; i < oldLength; i++)
            {
                newArray[i] = currentArray[i];

            }

            return newArray;
        }

        private void PrintEployeesInfo()
        {
            for (int i = 0; i < _employeesName.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1}. {_employeesName[i, 1]} {_employeesName[i, 0]} {_employeesName[i, 2]} - {_jobName[i]}");
            }
        }

        private void DeleteEmployeeInfo(int index)
        {
            int oldLength = _employeesName.GetLength(0);

            if (index < 0 || index >= oldLength)
            {
                Console.WriteLine("Индекс вне диапазона");
                return;
            }

            string[,] newEmployeesName = new string[oldLength - 1, 3];
            string[] newJobName = new string[oldLength - 1];

            for (int i = 0, j = 0; i < oldLength; i++)
            {
                if (i == index) continue;

                newEmployeesName[j, 0] = _employeesName[i, 0];
                newEmployeesName[j, 1] = _employeesName[i, 1];
                newEmployeesName[j, 2] = _employeesName[i, 2];
                newJobName[j] = _jobName[i];
                j++;
            }

            _employeesName = newEmployeesName;
            _jobName = newJobName;
        }

        private void SearchBySurname(string surname)
        {
            int userId = -9999;
            int oldLength = _employeesName.GetLength(0);
            for (int i = 0, j = 0; i < oldLength; i++)
            {
                if (_employeesName[i, 1] == surname)
                {
                    userId = i;
                    break;
                }
            }

            if (userId >= 0)
            {
                Console.WriteLine("Пользователь которого вы искали найден, им является: \n" + 
                                  $"{userId + 1}." +
                                  $" {_employeesName[userId, 1]}" +
                                  $" {_employeesName[userId, 0]}" +
                                  $" {_employeesName[userId, 2]}" +
                                  $" {_jobName[userId]}");
                return;
            }
            else
            {
                Console.WriteLine("Искомый сотрудник не найден, попробуйте снова!");
                return;
            }
        }
    }
}

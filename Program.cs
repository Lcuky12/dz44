using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const string SetName = "установить имя";
           const string ChangeConsoleColor = "изменять цвет консоли";
           const string SetPassword = "установить пароль";
           const string WriteName = "вывести имя";
           const string Esc = "выход из программы";
           const string PasswordHint = "подсказка для пароля";
           const string EnterNumber = "введите число";
           const string EnterAmountMoney = "Введите количество денег";
           const string ShowAmountMoneySafe = "Показать количество денег в сейфе";

            string setName;
            string setPassword;
            string writeName;
            bool canExamination = true;
            string passwordHint;
            int enterNumber;
            int enterAmountMoney;
            int showAmountMoneySafe;
            string changeConsoleColorl;
            string userInput;
            string esc = "выход из программы";

            Console.WriteLine(" Введите нужные значения ");

            Console.Write(" установите имя ");
            setName= Console.ReadLine();
            Console.Write(" измените цвет консоли ");
            changeConsoleColorl= Console.ReadLine();
            Console.Write(" установите пароль ");
            setPassword = Console.ReadLine();
            Console.Write(" введите имя ");
            writeName = Console.ReadLine();
            Console.Write(" введите число ");
            enterNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write(" введите количество денег ");
            enterAmountMoney= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Вам нужно выбрать одну из следующих команд ");

            while (canExamination)
            {
                Console.WriteLine(SetName);
                Console.WriteLine(ChangeConsoleColor);
                Console.WriteLine(SetPassword);
                Console.WriteLine(WriteName);
                Console.WriteLine(Esc);
                Console.WriteLine(PasswordHint);
                Console.WriteLine(EnterNumber);
                Console.WriteLine(EnterAmountMoney);
                Console.WriteLine(ShowAmountMoneySafe);
                userInput = Console.ReadLine();

                if (userInput == esc)
                {
                    canExamination = false;
                }

                switch (userInput)
                {
                    case SetName:
                        
                }
            }
        }
    }
}

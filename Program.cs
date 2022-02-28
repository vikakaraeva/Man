using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user_command = "";// переменная, которая будет хранить команду пользовател
            bool Infinity = true; // бесконечный цикл

            // пустой (раный null) экземпляр класса Man
            Man SomeMan = null;

            while (Infinity) // пока Infinity равно true
            {

                System.Console.WriteLine("Пожалуйста, введите команду"); // приглашение ввести команду
                user_command = System.Console.ReadLine(); // получение строки (команды) от пользователя


                // обработка команды с помощью оператора ветвления
                switch (user_command)
                {
                    case "create_man":
                        { // проверяем, создан ли уже какой либо человек
                            if (SomeMan != null)
                            { // человек уже существует. 
                              // убиваем его 
                                SomeMan.Kill();
                            }
                            // просим ввести имя человека
                            System.Console.WriteLine("Пожалуйста, введите имя создаваемого человека ");
                            // получаем строку введенную пользователем
                            user_command = System.Console.ReadLine(); // создаем новый объект в памяти, в качестве параметра, передаем имя человека
                            SomeMan = new Man(user_command); // сообщаем о создании
                            System.Console.WriteLine("Человек успешно создан ");
                            break;
                        }
                    case "kill_man":
                        {
                            if (SomeMan != null) // проверяем, что объект существует в памяти
                            {
                                // вызываем фукнцию сметри
                                SomeMan.Kill();
                                System.Console.WriteLine("Человек убит");
                            }
                            break;
                        }
                    case "talk":
                        {

                            if (SomeMan != null) // проверяем, что объект существует в памяти
                            {

                                SomeMan.Talk(); // вызываем функцию разговора
                            }
                            else // иначе
                            {
                                System.Console.WriteLine("Человек не создан. Команда не может быть выполнена");
                            }
                            break;
                        }


                    case "exit":
                        {
                            Infinity = false; // теперь цикл завершиться, и программа завершит свое выполнение
                            break;
                        }

                    case "go":
                        {
                            // проверяем, что объект существует в памяти
                            if (SomeMan != null)
                            { 
                                // вызываем функцию передвижения
                                SomeMan.Go();
                            }
                            else
                            {
                                System.Console.WriteLine("Человек не создан. Команда не может быть выполнена");
                            }
                            break;
                        }

                    // если user_command содержит строку help
                    case "help":
                        {
                            System.Console.WriteLine("Список команд:");
                            System.Console.WriteLine("---");
                            System.Console.WriteLine("create_man : команда создает человека, (экземпляр класса Man)");
                            System.Console.WriteLine("kill_man : команда убивает человека");
                            System.Console.WriteLine("talk : команда заставляет человека говорить (если создан экземпляр класса)");
                            System.Console.WriteLine("go : команда заставляет человека идти (если создан экземпляр класса)");
                            System.Console.WriteLine("exit: выход из программы");
                            System.Console.WriteLine("---");
                            System.Console.WriteLine("---");
                            break;
                        }
                    // если команду определить не удалось
                    default:
                        {

                            System.Console.WriteLine("Ваша команда не определена, пожалуйста, повторите снова");
                            System.Console.WriteLine("Для вывода списка команд введите команду help");
                            System.Console.WriteLine("Для завершения программы введите команду exit");
                            break;
                        }
                }
                
            }

        }
    }
}
    

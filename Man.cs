using System;
using System.Collections.Generic;
using System.Text;

namespace Program

{

    public class Man
    {
        // конструктор класса, данная функция вызывается при создании нового экземпляра класса

        public Man(string _name)
        {
            //конструктор класса
            Name = _name; //получаем имя человека из входного параметра
            isLife = true; //жив
            Age = (uint)rnd.Next(15, 51);//генерируем возраст 
                                         //функция rnd возвращает значение с типом
                                         //intunsigned – т.е. беззнаковое int


            Health = (uint)rnd.Next(10, 101); //генерируем здоровье в %
        }

        // экземпляр класса Random для генерации случайных чисел

        private Random rnd = new Random();

        private string Name; // строка, содержащая имя
                            // закрытые члены, которые нельзя изменить извне класса
        private uint Age; // беззнаковое целое число, содержащая возраст              
        private uint Health; // беззнаковое целое число, отражающее уровень здоровья 
        private bool isLife;  // булево, означающее жив ли данный человек


        // заготовква функции "говорить"
        public void Talk()
        {
            int random_talk = rnd.Next(1, 4);// генерируем случайное число от 1 до 3
            string tmp_str = ""; // объявляем переменную, в которой мы будем хранить строку
                                 // в зависимости от случ значения random_talk

            switch (random_talk)
            {
                case 1: // если 1 - называем свое имя
                    { // генерируем текст сообщения
                        tmp_str = "Привет, меня зовут " + Name + ", рад познакомиться";
                        // завершаем оператор выбора
                        break;

                    }
                case 2: // возраст
                    {
                        tmp_str = "Мне " + Age + ". А тебе?";
                        // завершаем оператор выбора
                        break;
                    }
                case 3: // говорим о своем здоровье
                    {
                        if (Health > 50)
                            tmp_str = "Да я здоров как бык!";
                        else
                            tmp_str = "Со здоровьем у меня хреново, дожить бы до " + (Age + 10).ToString();
                        // завершаем оператор выбора
                        break;
                    }
            }
            // выводим в консоль сгенерированное сообщение
            System.Console.WriteLine(tmp_str);
        }





        // заготовка функции "идти"
        public void Go()
        {

            if (isLife == true) // если объект жив
            {
                if (Health > 40) // если показатель более 40 считаем объект здоровым
                {
                    string outString = Name + " мирно прогуливается по городу"; // генерируем строку текста
                    System.Console.WriteLine(outString); //выводим в консоль
                }
                else
                {
                    // генерируем строку текста
                    string outString = Name + " болен и не может гулять по городу";
                    System.Console.WriteLine(outString);
                }
            }
            else
            {
                string outString = Name + " не может идти, он умер";
                System.Console.WriteLine(outString);
            }

        }

        // функция, возвращающая показатель - жив ли данный человек.
        public bool IsAlive()
        {
            return isLife; // возращаем значение, к которому мы не можем  обратиться напрямую из вне класса, так как оно имеет статус private
        }
        //функция, которая убивает нашего человека.

        public void Kill()
        {
            isLife = false; // устанавливаем значение isLife (жив) в false
        }
    }
}



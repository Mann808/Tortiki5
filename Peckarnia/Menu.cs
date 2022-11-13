using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace Peckarnia
{
    class Enter
    {
        public int sum;
        public string [] data = new string[4];
        public string zagaz;
        public void begin()
        {
            Title = "asd";
            RunmainMenu();
            ReadKey(true);
        }
        private void RunmainMenu()
        {
            while (true)
            {
                string[] options = { "1. Форма тортика", "2. Глазурь", "3. Взбитые сливки", "4. Из чего сделана основа", "5. Какой цвет шоколада", "6. Вывести заказ", "7. Выход" };
                foreach (string item in data)
                {
                    zagaz+= item;
                    data[0] = default;
                }
                string start = $"Ваш заказ: {zagaz} На сумму: {sum}";
                Menu mainMenu = new Menu(options,start);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        Forma();
                        break;
                    case 1:
                        Glazur();
                        break;
                    case 2:
                        Slivki();
                        break;
                    case 3:
                        Osnova();
                        break;
                    case 4:
                        Colors();
                        break;
                    case 5:
                        Order(zagaz,sum);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }

        }
        public void Forma()
        {
            string start = $"Ваш заказ: {zagaz}, На сумму: {sum}";
            string[] options = { "1. Круглая - 200", "1. Квадратная - 300", "1. Прямоугольная - 350", "1. Звездочкой - 425", "То самое нажжатие ESC" };
            Menu mainMenu = new Menu(options,start);
            int Index = mainMenu.strelocki();
            switch (Index)
            {
                case 0:
                    sum += 200;
                    data[0] += "Круглая форма,";
                    break;
                case 1:
                    sum += 300;
                    data[0] += "Квадратная форма,";
                    break;
                case 2:
                    sum += 350;
                    data[0] += "Прямоугольная форма,";
                    break;
                case 3:
                    sum += 425;
                    data[0] += "Звездочная форма,";
                    break;
                case 4:
                    Console.WriteLine("Нажмите ESC");
                    Console.ReadKey();
                    RunmainMenu();
                    break;
            }
            
        }
        public void Glazur()
        {
                string start = $"Ваш заказ: {zagaz} На сумму: {sum}";
                string[] options = { "1. Мармеладная - 200", "1. Фруктовая - 300", "1. Ванильная - 350", "1. Кексовая - 425", "То самое нажжатие ESC" };
                Menu mainMenu = new Menu(options, start);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        sum += 200;
                        data[0] += "Глазурь мармеладная,";
                        break;
                    case 1:
                        sum += 300;
                        data[0] += "Глазурь фруктовая,";
                        break;
                    case 2:
                        sum += 350;
                        data[0] += "Глазурь ванильная,";
                        break;
                    case 3:
                        sum += 425;
                        data[0] += "Глазурь кексовая,";
                        break;
                    case 4:
                        Console.WriteLine("Нажмите ESC");
                        Console.ReadKey();
                        RunmainMenu();
                        break;
                }
        }
        public void Slivki()
        {
                string start = $"Ваш заказ: {zagaz} На сумму: {sum}";
                string[] options = { "1. Взбитые сливки - 200", "1. Молочные сливки - 300", "1. Масленные сливки - 350", "1. Радужные сливки - 425", "То самое нажжатие ESC" };
                Menu mainMenu = new Menu(options, start);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        sum += 200;
                        data[0] += "Взбитые сливки,";
                        break;
                    case 1:
                        sum += 300;
                        data[0] += "Молочные сливки,";
                        break;
                    case 2:
                        sum += 350;
                        data[0] += "Масленные сливки,";
                        break;
                    case 3:
                        sum += 425;
                        data[0] += "Радужные сливки,";
                        break;
                    case 4:
                        Console.WriteLine("Нажмите ESC");
                        Console.ReadKey();
                        RunmainMenu();
                        break;
                }
        }
        public void Osnova()
        {
                string start = $"Ваш заказ: {zagaz} На сумму: {sum}";
                string[] options = { "1. Пшенная - 200", "1. Зерновая - 300", "1. Фисташковая - 350", "1. Ячменаая мука, - 425", "То самое нажжатие ESC" };
                Menu mainMenu = new Menu(options, start);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        sum += 200;
                        data[0] += "Пшенная мука,";
                        break;
                    case 1:
                        sum += 300;
                        data[0] += "Зерновая мука,";
                        break;
                    case 2:
                        sum += 350;
                        data[0] += "Фисташковая мука,";
                        break;
                    case 3:
                        sum += 425;
                        data[0] += "Ячменаая мука,";
                    break;
                    case 4:
                        Console.WriteLine("Нажмите ESC");
                        Console.ReadKey();
                        RunmainMenu();
                        break;
                }
        }
        public void Colors()
        {

                string start = $"Ваш заказ: {zagaz} На сумму: {sum}";
                string[] options = { "1. Шоколад коричневый - 200", "1. Шоколад розовый - 300", "1. Шоколад белый - 350", "1. Шоколад радужный - 425", "То самое нажжатие ESC" };
                Menu mainMenu = new Menu(options, start);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        sum += 200;
                        data[0] += "Шоколад коричневый,";
                        break;
                    case 1:
                        sum += 300;
                        data[0] += "Шоколад розовый,";
                        break;
                    case 2:
                        sum += 350;
                        data[0] += "Шоколад белый,";
                        break;
                    case 3:
                        sum += 425;
                        data[0] += "Шоколад радужный,";
                        break;
                    case 4:
                        Console.WriteLine("Нажмите ESC");
                        Console.ReadKey();
                        RunmainMenu();
                        break;
                }
            }
        public void Order(string zagaz, int sum)
        {
            string ordertext = $"\nЗаказ от {DateTime.Now}\n" + $"\tЗаказ: {zagaz}\n\tЦена: {sum} рублей";
            string path = "C:\\Users\\Mann\\Desktop\\Тортнаскорубруку.txt";
            if (File.Exists(path))
            {
                File.AppendAllText(path, ordertext);
            }
            else
            {
                var text = File.Create(path);
                text.Close();
                File.WriteAllText(path, ordertext);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using SportLibrary;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.InputEncoding = System.Text.Encoding.UTF8;

            int menu = -1;
            while(menu != 4)
            {
                PrintMenu();
                if(int.TryParse(Console.ReadLine(), out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            {
                                RunBikers();
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                        case 3:
                            {
                                break;
                            }
                        case 4:
                            {
                                //пустой пункт
                                break;
                            }
                    }
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Соревнования Велосипендистов");
            Console.WriteLine("2. Соревнования Прыгунов");
            Console.WriteLine("3. Соревнования Бегунов");
            Console.WriteLine("4. Завершить работу");
            Console.Write("Выберите пункт меню: ");
        }

        static void RunBikers()
        {
            int disctance = -1;
            int windVelocity = -1;

            List<Biker> bikers = new List<Biker>();
            while (true)
            {
                Console.Write("Введите дистанцию: ");
                if(int.TryParse(Console.ReadLine(),out disctance) && disctance > 0)
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("Введите скорость ветра: ");
                if (int.TryParse(Console.ReadLine(), out windVelocity))
                {
                    break;
                }
            }
            Console.WriteLine("В забеге будут участвовать 3 человек");
            // заменить на 8
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите ФИО участника: ");
                var fio = Console.ReadLine().Split(' ');
                int age;
                while (true)
                {
                    Console.WriteLine("Введите возраст: ");
                    if(int.TryParse(Console.ReadLine(),out age) && age > 0)
                    {
                        break;
                    }
                }
                int velocity = -1;
                while (true)
                {
                    Console.WriteLine("Введите скорость велосипедиста: ");
                    if (int.TryParse(Console.ReadLine(), out velocity) && velocity > 0)
                    {
                        break;
                    }
                }
                bikers.Add(new Biker()
                {
                    LastName = fio[0],
                    FirstName = fio[1],
                    Age = age,
                    Velocity = velocity
                });
            }

            foreach(var biker in bikers)
                biker.ToDo(1.0*disctance,1.0 * windVelocity);

            foreach(var item in Referee.SortResult(bikers.ToArray()))
            {
                var biker = item as Biker;
                Console.WriteLine(biker.ToString());
            }




        }


    }
}

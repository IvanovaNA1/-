using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автомобиль
{
    internal class Меню
    {
        private static Car[] cars = new Car[0];
        public static void Menu(ref int num)
        {
            Console.WriteLine("1 - Добавить автомобиль\n2 - Вывод информации о автомобилях\n3 - Найти автомобиль\nЧтобы выбрать услугу, введите цифру от 1 до 3.");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1: PlusCar(ref cars); break;
                case 2: Console.WriteLine("Введите номер машины");
                    int numcar = int.Parse(Console.ReadLine());
                    CarInfo(cars, numcar); break;
                case 3: FindCar(ref cars); break;
                default:
                    Console.WriteLine("Такой услуги нет. Введите цифру от 1 до 3!"); break;
            }
        }

        private static void PlusCar(ref Car[] cars)
        {
            Car[] pluscar = new Car[cars.Length + 1];
            cars.CopyTo(pluscar, 0);
            cars = pluscar;
            Console.WriteLine("Введите параметры новой машины:");

            Console.WriteLine("Марка:");
            string brand = Console.ReadLine();
            Console.WriteLine("Модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Цвет:");
            string colour = Console.ReadLine();
            Console.WriteLine("Номер:");
            int number = int.Parse(Console.ReadLine());
            Car newCar = new Car(brand, model, colour, number);
            cars[^1] = newCar;
        }

        private static void CarInfo(Car[] cars, int number)
        {
            if (number > cars.Length)
            {
                Console.WriteLine("Такой машины нет");
            }
            cars[number].GetInfo();
        }

        public static void FindCar(ref Car[] cars)
        {
            Console.WriteLine("Введите номер машины");
            int number = int.Parse(Console.ReadLine());
            int index = 0;
            bool found = false;
            foreach (Car car in cars)
            {
                if (car.number == number)
                {
                    found = true;
                    car.GetInfo();
                    Console.WriteLine($"Положение в списке: {index}");
                    break;
                }
                index++;
            }
            if (found == false) Console.WriteLine("Не смогли найти");
        }
    }
}

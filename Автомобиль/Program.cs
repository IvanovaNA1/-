using System.ComponentModel.Design;
using Автомобиль;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car();
        Console.WriteLine(car1.GetInfo());
        Car car2 = new Car("Nissan", "Duo", "Black", 2);
        Console.WriteLine(car2.GetInfo());
        
        int num = 0;
        while (num != 4)
        {
            Меню.Menu(ref num);
        }


    }
}
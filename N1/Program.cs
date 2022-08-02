using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1 //1.   Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите значение угла");
                int d = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                int s = Convert.ToInt32(Console.ReadLine());
                angle = new Angle(d, m, s); //? :(
            }
            while (angle.isCorrect == false);

            double radAngle = angle.ToRadians();
            Console.WriteLine(radAngle);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitкр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        Random random = new Random();
        double x1 = random.NextDouble() * 10;
        double y1 = random.NextDouble() * 10; 
        double x2 = random.NextDouble() * 10; 
        double y2 = random.NextDouble() * 10; 
        Console.WriteLine("Координаты первой точки: ({0}, {1})", x1, y1);
        Console.WriteLine("Координаты второй точки: ({0}, {1})", x2, y2);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Расстояние между двумя точками: {0}", distance);

<<<<<<< HEAD
            //площадь куба
            
            //периметр куба

            //объём куба 
=======
        //длина окружности с радиусом равным расстоянию точек

        //площадь окружности
>>>>>>> master

            Console.ReadLine();
        }
}



        }


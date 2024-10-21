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
        Console.WriteLine($"Координаты первой точки: ({0}, {1})", x1, y1);
        Console.WriteLine($"Координаты второй точки: ({0}, {1})", x2, y2);


            Console.ReadLine();
        }
}



        }


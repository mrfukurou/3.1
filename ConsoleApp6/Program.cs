using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp6
{
    class Program
    {
        public double f(double x1, double y1, double x2, double y2)
        {
            x1 -= x2;
            y1 -= y2;
            return Math.Sqrt(x1 * x1 + y1 * y1);
        }
        public double max (double a, double b)
            {
            if (a < b) return b;
            else return a;
            }
        static void Main(string[] args)
        {
            try
            {
                Program pr = new Program();
                Console.Write("Введите координату х1: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату у1: ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату х2: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату у2: ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату х3: ");
                double x3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату у3: ");
                double y3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Длина отрезка с координатами [" + x1 + ";" + y1 + "] = {0}", pr.f(0, 0, x1, y1));
                Console.WriteLine("Длина отрезка с координатами [" + x2 + ";" + y2 + "] = {0}", pr.f(0, 0, x2, y2));
                Console.WriteLine("Длина отрезка с координатами [" + x3 + ";" + y3 + "] = {0}", pr.f(0, 0, x3, y3));

                double a, b, c, Max;

                Max = pr.max((pr.max(a = (pr.f(0, 0, x1, y1)), (b = (pr.f(0, 0, x2, y2))))), (pr.max(c = (pr.f(0, 0, x3, y3)), (b = (pr.f(0, 0, x2, y2))))));
                if (Max == a) { Console.WriteLine("Наиболее отдалена первая точка: " + Max); }
                else if (Max == b) { Console.WriteLine("Наиболее отдалена вторая точка: " + Max); }
                else { Console.WriteLine("Наиболее отдалена третья точка: " + Max); }
            }
            catch { Console.WriteLine("Некорректный ввод!"); }
            Console.ReadKey();
        }     
    }
}

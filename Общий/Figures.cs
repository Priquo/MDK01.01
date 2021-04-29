using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    interface Triangle
    {
        void Square();
        void Perimetr();
        
    }
    interface Pram
    {
        void Square();
        void Perimetr();
        
    }
    class Figures: Triangle, Pram
    {
        double a, b, c, x1, x2, x3, y1, y2, y3, S, P, pol;
        public Figures(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Figures(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public Figures(int i)
        {
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            a = Math.Abs(y1 - y2);
            b = Math.Abs(x1 - x2);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Вы ввели координаты одной стороны, это не гуд");
            }
        }
        public Figures()
        {
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
        }
        void Triangle.Square()
        {
            try
            {
                pol = (a + b + c) / 2;
                S = Math.Sqrt(pol * (pol - a) * (pol - b) * (pol - c));
            }
            catch (Exception)
            {}
            Console.WriteLine("Площадь равна {0}", S);
        }
        void Triangle.Perimetr()
        {
            try
            {
                P = a + b + c;
                Console.WriteLine("Периметр равен {0}", P);
            }
            catch (Exception)
            { }
        } 
        void Pram.Square()
        {
            S = a * b;
            Console.WriteLine("Площадь равна {0}", S);
        }
        void Pram.Perimetr()
        {
            P = 2 * (a + b);
            Console.WriteLine("Периметр равен {0}", P);
        }
    }
}

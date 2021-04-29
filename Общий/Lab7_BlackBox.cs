using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class Lab7_BlackBox
    {
        double Q, R, S, fi, x1, x2, x3, a, b, c;
        public Lab7_BlackBox(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("Ваше уравнение:\nx^3 + {0}x^2 + {1}x + {2}", a, b, c);
        }
        public void Resh()
        {
            Q = (a * a - 3 * b) / 9;
            R = (2 * a * a * a - 9 * a * b + 27 * c) / 54;
            S = Q * Q * Q - R * R;
            if (S > 0)
            {
                fi = Math.Acos(R/Math.Sqrt(Q*Q*Q))/3;
                x1 = (-2) * Math.Sqrt(Q) * Math.Cos(fi) - a / 3;
                x2 = (-2) * Math.Sqrt(Q) * Math.Cos(fi+(2*Math.PI)/3) - a / 3;
                x3 = (-2) * Math.Sqrt(Q) * Math.Cos(fi-(2*Math.PI)/3) - a / 3;
                Console.WriteLine("fi = {0}", fi);
                //Console.WriteLine("Q = {0}\nR = {1}\nS = {2}", Q, R, S);
                Console.WriteLine("x1 = {0};  x2 = {1};  x3 = {2}", x1, x2, x3);
            }
            else
            {
                Console.WriteLine("Q = {0}\nR = {1}\nS = {2}\nПри S<0 или S=0 метод не прорабатываем", Q, R, S);
            }
        }
    }
}

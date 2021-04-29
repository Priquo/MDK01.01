using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    delegate void DelegSim(char c);
    delegate int DelegSimText(char c, string s);
    delegate void DelegQuadrResh(double a, double b, double c);
    class Deleg
    {
        char c;
        public void Simvol(char c)
        {
            this.c = c;
            Console.WriteLine("Я записал символ " + c);
        }
        public int FindSimInText(char c, string s)
        {
            int count;
            count = s.Length - s.Replace(Convert.ToString(c), "").Length;
            Console.WriteLine("Число вхождений символа "+c+" в строку "+s+" равно {0}", count);
            return count;
        }
        public int FindIndexSimInText(char c, string s)
        {
            int count;
            count = s.IndexOf(c);
            Console.WriteLine("Индекс символа "+c+" в строке "+s+" равен {0}", count);
            return count;
        }
    }
}

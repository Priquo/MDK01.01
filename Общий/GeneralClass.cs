using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    delegate C Del1<A, B, C>(A x, B y);

    class GeneralClass<GenCl>
    {
        GenCl a;
        public GeneralClass(GenCl a)
        {
            this.a = a;
        }
        public override string ToString()
        {
            return a.ToString();
        }
    }

    class OtherGenericClass<GenCl> : GeneralClass<GenCl>
    {
        public OtherGenericClass(GenCl a): base(a){}
    }
    class JustClass : GeneralClass<int>
    {
        public JustClass(int a) : base(a){}
        public double InStep(int a, int b)
        {
            return Math.Pow(a, b);
        }
        public int Summ(double a, double b)
        {
            return (int)(a+b);
        }
        public string Concat(char a, char b)
        {
            return "" + a + b;
        }
    }

    interface GeneralInterface<InterGen>
    {
        InterGen ShowMe(InterGen i);
    }

    class ForInterGen<InterGen> : GeneralInterface<InterGen>
    {
        public InterGen ShowMe(InterGen i)
        {
            return i;
        }
    }
    class JustForInterGen : GeneralInterface<string>
    {
        public string ShowMe(string i)
        {
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class NewOper
    {
        public int a;
        public string s;
        //string def = "один два три четыре пять шесть семь восемь девять ноль";
        public NewOper(int a, string s)
        {
            this.a = a;
            this.s = s;
        }
        public override string ToString()
        {
            return "строковое поле равно " + s + ", числовое поле равно " + a;
        }
        public override bool Equals(object obj)
        {
            NewOper temp = (NewOper)obj;
            if (a == temp.a && s.ToLower() == temp.s.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int INTplusRandom
        {
            get
            {
                Random rand = new Random();
                return a + rand.Next(-10, 10);
            }
            set
            {
                a = value;
            }
        }
        public int StrokNumbers()
        {
            if (s.ToLower() == "один")
            {
                return 1;
            }
            else if (s.ToLower() == "два")
            {
                return 2;
            }
            else if (s.ToLower() == "три")
            {
                return 3;
            }
            else if (s.ToLower() == "четыре")
            {
                return 4;
            }
            else if (s.ToLower() == "пять")
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
        public static int operator +(NewOper a1, NewOper a2)
        {
            return a1.a + a2.a;
        }
        public static int operator -(NewOper a1, NewOper a2)
        {
            return a1.a - a2.a;
        }
        public static int operator /(NewOper a1, NewOper a2)
        {
            try
            {
                return a1.a / a2.a;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static int operator *(NewOper a1, NewOper a2)
        {
            return a1.a * a2.a;
        }
        public static bool operator <(NewOper a1, NewOper a2)
        {
            if ((a1.a < a2.a) && (a1.StrokNumbers() < a2.StrokNumbers()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(NewOper a1, NewOper a2)
        {
            if ((a1.a > a2.a) && (a1.StrokNumbers() > a2.StrokNumbers()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(NewOper a1, NewOper a2)
        {
            if ((a1.a <= a2.a) && (a1.StrokNumbers() <= a2.StrokNumbers()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(NewOper a1, NewOper a2)
        {
            if ((a1.a >= a2.a) && (a1.StrokNumbers() >= a2.StrokNumbers()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(NewOper a1, NewOper a2)
        {
            if ((a1.a == a2.a) && (a1.StrokNumbers() == a2.StrokNumbers()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(NewOper a1, NewOper a2)
        {
            if ((a1.a != a2.a) && (a1.StrokNumbers() != a2.StrokNumbers()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string operator &(NewOper a1, NewOper a2)
        {
            try
            {
                int rez = a1.StrokNumbers() + a2.StrokNumbers();
                switch (rez)
                {
                    case 1:
                        return "один";
                    case 2:
                        return "два";
                    case 3:
                        return "три";
                    case 4:
                        return "четыре";
                    case 5:
                        return "пять";
                    case 6:
                        return "шесть";
                    case 7:
                        return "семь";
                    case 8:
                        return "восемь";
                    case 9:
                        return "девять";
                    case 0:
                        return "ноль";
                }
            }
            catch (Exception e)
            {
                return "" + e;
            }
            return "[данные удалены]";
        }
    }
}

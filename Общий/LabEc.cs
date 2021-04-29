using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class LabEc
    {
        double x, y;

        void CheckIn(out double a)
        {
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверный ввод. Введите вещественное число");
            }
        }
        void CheckIn(out int a)
        {
            while (!int.TryParse(Console.ReadLine(), out a) || Math.Abs(a) < 100 || Math.Abs(a) > 999)
            {
                Console.WriteLine("Неверный ввод. Введите целое трехзначное число");
            }
        }
        void CheckIn(out int a, int b)
        {
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0)
            {
                Console.WriteLine("Неверный ввод. Введите целое трехзначное число");
            }
        }
        public void Zad1()
        {
            Console.WriteLine("Введите х и у через Enter");
            CheckIn(out x);
            CheckIn(out y);
            try
            {
                Console.WriteLine("Результат вычисления выражения: {0}", (3 + Math.Exp(y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x))));
            }
            catch (Exception e)
            {
                Console.WriteLine("Вот такое исключение вышло вместо результата выражения: " + e.Message);
                //throw;
            }
        }
        public void Zad2()
        {
            int a, sum;
            string b;
            Console.WriteLine("Введите трехзначное число");
            CheckIn(out a);
            b = Convert.ToString(a);
            sum = (int)b[0] + (int)b[1] + (int)b[2];
            if (sum % 2 == 0)
            {
                Console.WriteLine(true);
                //return true;
            }
            else
            {
                Console.WriteLine(false);
                //return false;
            }
        }
        public void Zad3()
        {
            uint n, k = 0;
            Console.WriteLine("Введите количество членов последовательности");
            try
            {
                n = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Члены последовательности первых {0} натуральных чисел", n);
                for (int i = 0; i < n; i++)
                {
                    if (k % 2 == 0)
                    {
                        Console.WriteLine(k);
                    }
                    k += 2;
                }
                Console.WriteLine("Больше чисел нет");
            }
            catch (Exception e)
            {
                Console.WriteLine("Вот такое исключение вышло вместо результата: " + e.Message);
                //throw;
            }
        }
        public void Zad4()
        {
            uint n;
            double sum = 1;
            Console.WriteLine("Введите n");
            try
            {
                n = Convert.ToUInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + 1 / (double)i;
                }
                Console.WriteLine("Результат вычисления: {0}", sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Вот такое исключение вышло вместо результата: " + e.Message);
            }
        }
        public void Zad5()
        {
            uint st, mon;
            int sd;
            Console.WriteLine("Введите стоимость книги");
            st = TryCatch();
            Console.WriteLine("Введите сумму");
            mon = TryCatch();
            try
            {
                
                sd = Convert.ToInt32(mon) - Convert.ToInt32(st);
                if (sd < 0)
                {
                    Console.WriteLine("Вам не хватает {0} денег", Math.Abs(sd));
                }
                else if (sd > 0)
                {
                    Console.WriteLine("Ваша сдача составила {0}", sd);
                }
                else
                {
                    Console.WriteLine("Спасибо");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Вот такое исключение вышло вместо результата: " + e);
            }
        }
        uint TryCatch()
        {
            try
            {
                return uint.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Вот такое исключение вышло вместо результата: " + e);
                return 0;
            }
        }
    }
}

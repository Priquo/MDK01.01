using System;

namespace Общий
{
    static class Lab8_downUpTestTest
    {
        //static int n;
        static Lab8_downUpTest pop = new Lab8_downUpTest(5);
        static public void InpArr()
        {            
            pop[0] = -7;
            pop[1] = 0;
            pop[2] = 3;
            pop[3] = -4;
            pop[4] = 3;
        }
        static public void Lab8_SumMod_Test()
        {
            try
            {
                //n = Convert.ToInt32(Console.ReadLine());
                //InpArr();
                int rez = 10;
                if (pop.SumModAfterZero() == rez)
                {
                    Console.WriteLine("Ожидаемая сумма по модулю: {0}\nТест пройдет успешно", rez);
                }
                else
                {
                    Console.WriteLine("Ожидаемая сумма по модулю: {0}\nСоответсвия нет, тест провален", rez);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так, и вот почему: " + e.Message);
            }
        }
        static public void Lab8_Min_Test()
        {
            try
            {
                //n = Convert.ToInt32(Console.ReadLine());
                //InpArr();
                pop.Min();
                int rez = 0;
                if (pop.minEl == rez)
                {
                    Console.WriteLine("Ожидаемый минимум по модулю: {0}\nТест пройдет успешно", rez);
                }
                else
                {
                    Console.WriteLine("Ожидаемая минимум по модулю: {0}\nСоответсвия нет, тест провален", rez);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так, и вот почему: " + e.Message);
            }
        }
        static public void Lab8_Sort_Test()
        {
            try
            {
                //n = Convert.ToInt32(Console.ReadLine());
                //InpArr();
                pop.SortLikeIwant();
                pop.OutArr();
                Console.WriteLine("Ожидаемый вид сортировки");
                Console.Write("-7\t3\t3\t0\t-4");

            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так, и вот почему: " + e.Message);
            }
        }
    }
}

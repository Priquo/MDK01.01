using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class Lab6_WhiteBox
    {
        int[] arr = new int[0];
        int summ=0;
        public Lab6_WhiteBox(int n)
        {
            try
            {
                Array.Resize(ref arr, n);
            }
            catch(Exception e)
            {
                Console.WriteLine("Что-то пошло не так, и вот почему: "+ e.Message);
            }
        }
        void CheckIn(out int a)
        {
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверный ввод. Введите целое число");
            }
        }
        public void OutArr()
        {
            foreach (int i in arr)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
        public void InputArr()
        {
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write("Элемент массива номер {0}: ", i);
                CheckIn(out arr[i]);
            }
        }
        public void SummEl()
        {
            if (arr.Length <= 2)
            {
                Console.WriteLine("Сумма равна нулю, так как по условию нечего складывать");
            }
            else
            {
                for (int i = 1; i < arr.Length-1; i++)
                {
                    summ = summ + arr[i];
                }
                Console.WriteLine("Сумма равна {0}", summ);
            }
        }
    }
}

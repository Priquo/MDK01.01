using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    abstract class Zad2_Parent
    {
        Random rand = new Random();
        protected int[] arr = new int[0];
        protected int max;
        protected int MaxEl
        {
            get
            {
                max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }
        public int ShowMaxEl
        {
            get
            {
                return MaxEl;
            }
        }
        public int this[int k]
        {
            get
            {
                return arr[k];
            }
            set
            {
                arr[k] = value;
            }
        }
        public Zad2_Parent(int h)
        {
            Array.Resize(ref arr, h);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-200, 200);
                Console.Write("{0}\t", arr[i]);
            }
            Console.Write("\n");
        }
        abstract public void Max();
        //public void Max()
        //{
        //    max = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (max < arr[i])
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    Console.WriteLine("\nМаксимум равен {0}", max);
        //}
        public virtual void Sort()
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            OutArr();
        }
        public void OutArr()
        {
            foreach (int i in arr)
            {
                Console.Write("{0}\t", i);
            }
        }
    }
    class Zad2_Child: Zad2_Parent
    {
        int imax, imin, min, temp;
        public Zad2_Child(int h): base(h)
        {

        }
        override public void Max()
        {
            max = arr[0];
            for (int i = 0; i < 50; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    imax = i;
                }
            }
            Console.WriteLine("\nМаксимум равен {0}, а его индекс {1}", max, imax);
        }
        public override void Sort()
        {
            Array.Sort(arr);
            OutArr();
            Console.WriteLine("\n");
        }
        public void Zamena()
        {
            min = arr[0];
            for (int i = 0; i < 50; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    imin = i;
                }
            }
            max = arr[0];
            for (int i = 0; i < 50; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    imax = i;
                }
            }
            temp = min;
            arr[imin] = arr[imax];
            arr[imax] = min;
            OutArr();
        }
        public static Zad2_Child operator +(Zad2_Child a1, Zad2_Child a2)
        {            
            if (a1.arr.Length >= a2.arr.Length)
            {
                Zad2_Child a3 = new Zad2_Child(a2.arr.Length);
                for (int i = 0; i < a2.arr.Length; i++)
                {
                    a3[i] = a1[i] + a2[i];
                }
                return a3;
            }
            else
            {
                Zad2_Child a3 = new Zad2_Child(a1.arr.Length);
                for (int i = 0; i < a1.arr.Length; i++)
                {
                    a3[i] = a1[i] + a2[i];
                }
                return a3;
            }            
        }
        public static Zad2_Child operator -(Zad2_Child a1, Zad2_Child a2)
        {
            if (a1.arr.Length >= a2.arr.Length)
            {
                Zad2_Child a3 = new Zad2_Child(a2.arr.Length);
                for (int i = 0; i < a2.arr.Length; i++)
                {
                    a3[i] = a1[i] - a2[i];
                }
                return a3;
            }
            else
            {
                Zad2_Child a3 = new Zad2_Child(a1.arr.Length);
                for (int i = 0; i < a1.arr.Length; i++)
                {
                    a3[i] = a1[i] - a2[i];
                }
                return a3;
            }
        }
        public static Zad2_Child operator *(Zad2_Child a1, Zad2_Child a2)
        {
            if (a1.arr.Length >= a2.arr.Length)
            {
                Zad2_Child a3 = new Zad2_Child(a2.arr.Length);
                for (int i = 0; i < a2.arr.Length; i++)
                {
                    a3[i] = a1[i] * a2[i];
                }
                return a3;
            }
            else
            {
                Zad2_Child a3 = new Zad2_Child(a1.arr.Length);
                for (int i = 0; i < a1.arr.Length; i++)
                {
                    a3[i] = a1[i] * a2[i];
                }
                return a3;
            }
        }
        public static Zad2_Child operator /(Zad2_Child a1, Zad2_Child a2)
        {
            if (a1.arr.Length >= a2.arr.Length)
            {
                Zad2_Child a3 = new Zad2_Child(a1.arr.Length);
                for (int i = 0; i < a1.arr.Length; i++)
                {
                    try
                    {
                        a3[i] = a1[i] / a2[i];
                    }
                    catch (Exception)
                    {
                        return a3;
                    }
                    
                }
                return a3;
            }
            else
            {
                Zad2_Child a3 = new Zad2_Child(a2.arr.Length);
                for (int i = 0; i < a2.arr.Length; i++)
                {
                    try
                    {
                        a3[i] = a1[i] / a2[i];
                    }
                    catch (Exception)
                    {
                        return a3;
                    }
                }
                return a3;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class ArrManipulate
    {
        Random rand = new Random();
        protected int[] arr = new int[0];
        int[,] arrM;
        protected int n, m, imax, jmax, imin, jmin, max, min, k;
        public ArrManipulate(int k)
        {
            this.k = k;
            Array.Resize(ref arr, k);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
        }
        public ArrManipulate(int n, int m)
        {
            this.m = m;
            this.n = n;
            arrM = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrM[i, j] = rand.Next(-100, 100);
                }
            }
        }
        public void Max()
        {
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    imax = i;
                }
            }
            Console.WriteLine("\nМаксимум равен {0}, {1}-й элемент массива", max, imax);
        }
        public void Max(int l)
        {
            max = arrM[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)                
                    if (max < arrM[i,j])
                    {
                        max = arrM[i, j];
                        imax = i;
                        jmax = j;
                    }
            }
            Console.WriteLine("\nМаксимум равен {0} с индексами {1} и {2}", max, imax, jmax);
        }
        public virtual void Min()
        {
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    imin = i;
                }
            }
            Console.WriteLine("\nМинимум равен {0} с индексом {1}", min, imin);
        }
        public void Min(int l)
        {
            min = arrM[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (min > arrM[i, j])
                    {
                        min = arrM[i, j];
                        imin = i;
                        jmin = j;
                    }
            }
            Console.WriteLine("\nМинимум равен {0} с индексами {1} и {2}", min, imin, jmin);
        }
        public void OutArr()
        {
            foreach (int i in arr)
            {
                Console.Write("{0}\t", i);
            }
        }
        public void OutArr(int a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", arrM[i, j]);
                }
                Console.Write("\n");
            }
        }
        public void sort()
        {
            Array.Sort(arr);
            OutArr();
        }
        public void sort(int x)
        {
            int temp = 0;
            for (int k = 0; k < m * n; k++)
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (arrM[i, j] > arrM[i, j + 1])
                        {
                            temp = arrM[i, j];
                            arrM[i, j] = arrM[i, j + 1];
                            arrM[i, j + 1] = temp;
                        }
                    }
                }
            OutArr(1);
        }
    }
    class Menu
    {
        int answ = 1, k, l;

        void CheckIn(out int a)
        {
            while(!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверный ввод. Введите целое число");
            }
        }
        void CheckIn(out int a, int m)
        {
            while (!int.TryParse(Console.ReadLine(), out a) || a <0 || a>m)
            {
                Console.WriteLine("Неверный ввод. Введите целое число");
            }
        }
        public void Menu1()
        {            
            while (answ != 0)
            {                
                Console.WriteLine("\t\tМанипуляции с массивами\n1) Ввод размерности одномерного массива\n2) Ввод размерности двумерного массива\n0) Выход");
                CheckIn(out answ, 2);
                switch (answ)
                {
                    case 1:
                        Console.WriteLine("\t\tВведите размерность массива");
                        CheckIn(out k);
                        ArrManipulate ar = new ArrManipulate(k);
                        while (answ != 0)
                        {
                            Console.WriteLine("\n1) Нахождение минимума\n2) Нахождение максимума\n3) Сортировка\n4) Вывод массива \n0) Выход");
                            CheckIn(out answ, 4);
                            switch (answ)
                            {
                                case 1:
                                    ar.Min();
                                    break;
                                case 2:
                                    ar.Max();
                                    break;
                                case 3:
                                    ar.sort();
                                    break;
                                case 4:
                                    ar.OutArr();
                                    break;
                                case 0:
                                    break;
                            }
                        }                        

                        break;
                    case 2:
                        Console.WriteLine("\t\tВведите размерность массива");
                        CheckIn(out k);
                        CheckIn(out l);
                        ArrManipulate arM = new ArrManipulate(k, l);
                        while (answ != 0)
                        {
                            Console.WriteLine("\n1) Нахождение минимума\n2) Нахождение максимума\n3) Сортировка\n4) Вывод массива \n0) Выход");
                            CheckIn(out answ, 4);
                            switch (answ)
                            {
                                case 1:
                                    arM.Min(1);
                                    break;
                                case 2:
                                    arM.Max(1);
                                    break;
                                case 3:
                                    arM.sort(1);
                                    break;
                                case 4:
                                    arM.OutArr(1);
                                    break;
                                case 0:
                                    break;
                            }
                        }

                        break;
                    case 0:
                        break;
                }
            }            
        }
    }

}

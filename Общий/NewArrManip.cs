using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class NewArrManip
    {
        Random rand = new Random();
        int[] arr = new int[0];
        int[,] arrM;
        int iP, iN, temp, m, n;
        public NewArrManip(int k, int a, int b)
        {
            //this.k = k;
            Array.Resize(ref arr, k);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(a, b);
                Console.Write("{0}\t", arr[i]);
            }
            Console.Write("\n");
        }
        public NewArrManip(int n, int m)
        {
            this.m = m;
            this.n = n;
            arrM = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrM[i, j] = rand.Next(65, 90);
                }
            }
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
                    Console.Write("{0}\t", Convert.ToChar(arrM[i, j]));
                }
                Console.Write("\n");
            }
        }
        public void ChangeAndFind()
        {
            iP = Array.FindIndex(arr, i => i > 0);
            iN = Array.FindIndex(arr, i => i < 0);
            temp = arr[iP];
            arr[iP] = arr[iN];
            arr[iN] = temp;
            OutArr();
        }
        public void OstatokAndCeloe()
        {
            foreach(int i in arr)
            {
                Console.WriteLine("Число {0}, целое число деления на 5 - {1}, остаток от деления {2}, ", i, i / 5, i%5);
            }
        }
    }
    class MenuArr
    {
        int answ = 1, k, l, n;

        void CheckIn(out int a)
        {
            while (!int.TryParse(Console.ReadLine(), out a)|| a<0)
            {
                Console.WriteLine("Неверный ввод. Введите целое число");
            }
        }
        void CheckIn(out int a, int i, int k)
        {
            while (!int.TryParse(Console.ReadLine(), out a) || a < k || a > i)
            {
                Console.WriteLine("Неверный ввод. Введите целое число");
            }
        }
        public void Menu1()
        {
            while (answ != 0)
            {
                Console.WriteLine("\t\tМанипуляции с массивами\n1) Ввод размерности одномерного массива\n0) Выход");
                CheckIn(out answ, 1, 0);                
                switch (answ)
                {
                    case 1:                                              
                        while(answ != 2)
                        {
                            CheckIn(out n);
                            NewArrManip ar = new NewArrManip(n, -50, 50);
                            Console.WriteLine("\nНажмите 1, чтобы выполнить задачу, 2 - выйти в меню");
                            CheckIn(out answ, 2, 1);
                            switch (answ)
                            {
                                case 1:
                                    ar.ChangeAndFind();
                                    break;
                                case 2:
                                    break;
                            }
                        }
                        break;
                    case 0:
                        break;
                }
            }
        }
        public void Menu1(int j)
        {
            while (answ != 0)
            {
                Console.WriteLine("\t\tМанипуляции с натуральными числами\n1) Ввод размерности одномерного массива\n0) Выход");
                CheckIn(out answ, 1, 0);              
                switch (answ)
                {
                    case 1:
                        CheckIn(out n);
                        NewArrManip ar = new NewArrManip(n, 1, 9);
                        while (answ != 2)
                        {
                            Console.WriteLine("\nНажмите 1, чтобы выполнить задачу, 2 - выйти в меню");
                            CheckIn(out answ, 2, 1);
                            switch (answ)
                            {
                                case 1:
                                    ar.OstatokAndCeloe();
                                    break;
                                case 2:
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

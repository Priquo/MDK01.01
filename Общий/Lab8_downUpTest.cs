using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class Lab8_downUpTest: ArrManipulate
    {
        int ModSumm;
        public Lab8_downUpTest(int k): base(k)
        {

        }
        public int minEl
        {
            get
            {
                return min;
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
        public override void Min()
        {
            min = Math.Abs(arr[0]);
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > Math.Abs(arr[i]))
                {
                    min = Math.Abs(arr[i]);
                    imin = i;
                }
            }
            Console.WriteLine("\nМинимум по модулю равен {0} с индексом {1}", min, imin);
        }
        public int SumModAfterZero()
        {
            int p = Array.FindIndex(arr, i => i == 0);
            //Console.WriteLine("\nЭто индекс нуля {0}, сам ноль {1}", p, arr[p]);
            if (p > 0)
            {
                ModSumm = 0;
                for (int i = p; i < arr.Length; i++)
                {
                    ModSumm = ModSumm + Math.Abs(arr[i]);
                }
                Console.WriteLine("\nСумма модулей элементов после первого нуля равна {0}", ModSumm);
                return ModSumm;
            }
            else
            {
                Console.WriteLine("\nВ массиве нет нулей :(");
                return 0;
            }
        }
        public void SortLikeIwant()
        {            
            int[] tempChet;
            int[] tempNechet;
            int l = 0;
            int j = 0;            
            if (k%2 == 0)
            {               
                tempChet = new int[k / 2];
                tempNechet = new int[k / 2];
            }
            else if (k%2 != 0)
            {
                tempChet = new int[(k+1) / 2];
                tempNechet = new int[(k - 1) / 2];
            }
            else
            {
                tempChet = new int[0];
                tempNechet = new int[0];
            }

            for(int i = 0; i < k; i++)
            {                
                if (i%2 == 0)
                {
                    tempChet[l] = arr[i];
                    l++;
                }
                else if (i%2 != 0)
                {
                    tempNechet[j] = arr[i];
                    j++;
                }
            }
            j = 0;
            for (int i = 0; i < k; i++)
            {
                if (i< (k+1) / 2)
                {
                    arr[i] = tempChet[i];
                }
                else
                {
                    arr[i] = tempNechet[j];
                    j++;
                }
            }
        }
    }
}

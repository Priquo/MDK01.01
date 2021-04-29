using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Общий
{
    class Top10Quadr
    {
        int[] quadr = new int[10];
        public Top10Quadr()
        {
            for(int i = 1; i < 11; i++)
            {
                quadr[i - 1] = i * i;
            }
        }
        public void ShowTop10Quadr()
        {
            foreach(var v in quadr)
            {
                Console.WriteLine(v);
            }
        }
        public void Max()
        {
            int max = quadr[0];
            for (int i = 0; i < 10; i++)
            {
                if (max < quadr[i])
                {
                    max = quadr[i];
                    //Debug.WriteLine("max = {0}", max);
                    //if (i < 5) Debug.Fail("а чего у вас маскимум в первой половине?");
                    Trace.WriteLine("max = {0}", max.ToString());
                    if (i < 5) Trace.Fail("а чего у вас маскимум в первой половине?");
                }
            }
            //Console.WriteLine("\nМаксимум равен {0}", max);
        }
        public void Sort()
        {
            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (quadr[j] < quadr[j+1])
                    {
                        temp = quadr[j];
                        quadr[j] = quadr[j + 1];
                        quadr[j + 1] = temp;
                        //Debug.WriteLine("{0}\t", quadr[j].ToString());
                        Trace.WriteLine("{0}\t", quadr[j].ToString());
                    }
                }
            }
        }
    }
}

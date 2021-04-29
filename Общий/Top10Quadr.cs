using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

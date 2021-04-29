using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    struct Peple
    {
        public string name;
        public int month;
        public int numb_month;
        public Peple(string name, int month, int numb_month)
        {
            this.name = name;
            this.month = month;
            this.numb_month = numb_month;
        }        
    }
    class Zodiac
    {
        int[] numbers = new int[31];            // массив с числами месяца
        /*string months; */            // массив с номерами месяцев
        public Zodiac()
        {            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }            
            //for (int i = 0; i < months.Length; i++)
            //{
            //    months = Convert.ToString(i + 1 + " ");
            //}
        }
        public void ZodiacGet(Peple pep)
        {
            Array.IndexOf(numbers, pep.numb_month); 
        }
    }
}

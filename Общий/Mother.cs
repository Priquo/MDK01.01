using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    class Mother
    {
        public int age = 28;
        public string colorEye = "голубой";
        protected void show()
        {
            Console.WriteLine("Цвет глаз {1}, возраст {0}", age, colorEye);
        }
        protected virtual void vshow()
        {
            Console.WriteLine("Цвет глаз {1}, возраст {0}", age, colorEye);
        }
        public void display()
        {
            show();
            vshow();
        }

    }

    class Son:Mother
    {
        new protected void show()
        {
            Console.WriteLine("Я замещенный метод в производном классе");
        }
        //переопределяем виртуальный метод
        protected override void vshow()
        {
            Console.WriteLine("я переопределенный виртуальный метод");
        }

    }
}

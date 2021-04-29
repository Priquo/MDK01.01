using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Общий
{
    [Serializable]
    struct User
    {
        string name;        // имя
        string last_name;   // фамилия
        string otch;   // фамилия
        int age;            // возраст
        char sex;           // пол
        public User(string name, string last_name, string otch, int age, char sex)
        {
            this.name = name;
            this.last_name = last_name;
            this.otch = otch;
            this.age = age;
            this.sex = sex;
        }
        public string OutData()
        {
            return "Имя: " + name + " \tФамилия: " + last_name + "\tОтчество: "+ otch + "\tВозраст: " + age + "\tПол: " + sex;
        }
    }
    class StructFiles
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Collections;
using System.Diagnostics;

namespace Общий
{
    class Program
    {
        public struct User //структура для обобщенных списков
        {
            public string f;
            public string i;
            public string o;
            public char gender;
            public DateTime birth;
            public void show()
            {
                Console.WriteLine(f + " " + i + " " + o + " " + gender.ToString() + " " + birth.ToString("d"));
            }
        }
        static void Main(string[] args)
        {
            string path = @"X:\subjects\МДК 01.01\ДляФайлов\list.csv"; //путь для работы с файлами csv
            string path2 = @"X:\subjects\МДК 01.01\ДляФайлов\listener.txt";
            //char x = 'A';
            //Menu f = new Menu();
            //f.Menu1();
            //Console.ReadKey();

            // ####################### Всякая работа с массивами ##############################
            //MenuArr f = new MenuArr();
            //f.Menu1(1);
            //Console.WriteLine((int)x);
            //NewArrManip f = new NewArrManip(5, 10);
            //f.OutArr(1);

            // ####################### Поиски исключений ##############################
            //LabEc a = new LabEc();
            //a.Zad5();

            // ####################### Переопределение операторов ##############################
            //NewOper c1 = new NewOper(5, "пять");
            //NewOper c2 = new NewOper(5, "ПЯТЬ");
            //Console.WriteLine(c1.Equals(c2));

            // ####################### МДК 01.02 #######################
            // ####################### Тестирование черного и белого ящика ##############################
            //double n, m, k;

            //try
            //{
            //    n = Convert.ToDouble(Console.ReadLine());
            //    m = Convert.ToDouble(Console.ReadLine());
            //    k = Convert.ToDouble(Console.ReadLine());
            //    //Lab6_WhiteBox f = new Lab6_WhiteBox(n);
            //    //f.InputArr();
            //    //f.OutArr();
            //    //f.SummEl();
            //    Lab7_BlackBox f = new Lab7_BlackBox(n, m, k);
            //    f.Resh();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Что-то пошло не так, и вот почему: " + e.Message);
            //}
            // ####################### Нисходящее и восходящее тестирование ##############################
            //Lab8_downUpTest pop = new Lab8_downUpTest(5);
            //pop.OutArr();
            //pop.SumModAfterZero();
            //pop.SortLikeIwant();
            //pop.OutArr();
            //Lab8_downUpTestTest.InpArr();
            //Lab8_downUpTestTest.Lab8_SumMod_Test();
            //Lab8_downUpTestTest.Lab8_Min_Test();
            //Lab8_downUpTestTest.Lab8_Sort_Test();

            // ####################### Попытки использовать наследование ##############################
            //Mother a = new Mother();
            //Son b = new Son();
            //a.display();
            //b.age = 2;
            //b.colorEye = "зеленый";
            //b.display();

            // ####################### Наследование с замещениями методов. Наследование конструкторов, индексаторов, переопределение операторов ##############################
            //Zad2_Parent p = new Zad2_Parent();
            //p.Max();
            //p.Sort();

            //Zad2_Child ch = new Zad2_Child(90);
            //Thread.Sleep(10);
            //Zad2_Child ch1 = new Zad2_Child(70);
            //ch.Max();
            //int max = ch.ShowMaxEl;
            //Console.WriteLine("\n{0}", max);
            //ch.Max();
            //ch[0] = 1234;
            //Console.WriteLine(ch[0]);
            //ch.OutArr();
            //ch.Sort();
            //ch.Zamena();

            //Zad2_Child ch2 = ch * ch1;
            //ch2.OutArr();            

            // ####################### Абстрактные классы и интерфейсы ##############################
            //Triangle t = new Triangle(10, 8, 9);
            //t.Square();
            //t.Perimetr();

            //Pram p = new Pram(5, 4);
            //p.Square();
            //p.Perimetr();

            //Triangle ia = new TriangleObj(5, 4, 3);
            //ia.Square();
            //ia.Perimetr();

            // ####################### Делегаты и события ##############################
            //Deleg a1 = new Deleg();
            //DelegSim d = a1.Simvol;
            //d('h');
            //DelegSimText d1 = a1.FindSimInText;
            //d1 += a1.FindIndexSimInText;
            //d1('a', "aloha");            
            //DelegQuadrResh d2 = delegate (double a, double b, double c)
            //{
            //    double D = b * b - 4 * a * c;
            //    if (D == 0)
            //    {
            //        Console.WriteLine("Сумма корней равна {0}", (-b)/(2*a));
            //    }
            //    else if (D > 0)
            //    {
            //        Console.WriteLine("Сумма корней равна {0}", (-b + Math.Sqrt(D)) / (2 * a) + (-b - Math.Sqrt(D)) / (2 * a));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Считать нечего, корней нет");
            //    }
            //};
            //d2(1, 5, 6);
            //DelegQuadrResh d3 = (double a, double b, double c) =>
            //{
            //    double D = b * b - 4 * a * c;
            //    if (D == 0)
            //    {
            //        Console.WriteLine("Сумма корней равна {0}", (-b) / (2 * a));
            //    }
            //    else if (D > 0)
            //    {
            //        Console.WriteLine("Сумма корней равна {0}", (-b + Math.Sqrt(D)) / (2 * a) + (-b - Math.Sqrt(D)) / (2 * a));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Считать нечего, корней нет");
            //    }
            //};

            // ####################### Структуры и файлы ##############################
            //User Misha = new User("Миша", "Майоров", 18, 'м');
            //Console.WriteLine(Misha.OutData());
            //User[] users = new User[5];
            //users[0] = new User("Миша", "Майоров", 18, 'м');
            //users[1] = new User("Максим", "Котов", 18, 'м');
            //users[2] = new User("Никита", "Епихин", 19, 'м');
            //users[3] = new User("Никита", "Федоренков", 17, 'м');
            //users[4] = new User("Я", "Я", 18, 'ж');
            //foreach (var x in users)
            //{
            //    Console.WriteLine(x.OutData());
            //}            
            //try
            //{
            //    //File.CreateText(path);
            //    FileInfo f = new FileInfo(path);                                  
            //    using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            //    {
            //        foreach(var x in users)
            //        {
            //            sw.WriteLine(x.OutData());
            //        }                       
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Что-то пошло не так, и вот почему: " + e.Message);
            //}

            // ####################### Бинарные файлы ##############################
            //User u1 = new User("Миша", "Майоров", "Анатольевич", 18, 'м');
            //using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    bw.Write(u1.name);
            //    bw.Write(u1.last_name);
            //    bw.Write(u1.otch);
            //    bw.Write(u1.age);
            //    bw.Write(u1.sex);
            //}
            //User u2;
            //using (BinaryReader bw = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    u2 = new User(bw.ReadString(), bw.ReadString(), bw.ReadString(), bw.ReadInt32(), bw.ReadChar());
            //}
            //Console.WriteLine(u2.OutData());

            //User[] users = new User[5];
            //users[0] = new User("Миша", "Майоров", "Анатольевич", 18, 'м');
            //users[1] = new User("Максим", "Котов", "Батькович", 18, 'м');
            //users[2] = new User("Никита", "Епихин", "Батькович", 19, 'м');
            //users[3] = new User("Никита", "Федоренков", "Батькович", 17, 'м');
            //users[4] = new User("Я", "Я", "А", 18, 'ж');

            //User[] users1 = new User[1];

            //BinaryFormatter bf = new BinaryFormatter();
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    foreach (var x in users)
            //    {
            //        bf.Serialize(fs, x);
            //    }

            //    fs.Close();
            //}
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    int len = 0;
            //    try
            //    {
            //        while (true)
            //        {                        
            //            users1[len] = (User)bf.Deserialize(fs);                        
            //            len++;
            //            Array.Resize(ref users1, len + 1);
            //        }                    
            //    }
            //    catch
            //    {
            //        fs.Close();
            //    }
            //}

            //foreach (var x in users1)
            //{
            //    Console.WriteLine(x.OutData());
            //}

            // ####################### Регулярные выражения ##############################
            //Regex r = new Regex("^[0-9]{6}$");                             // почтовый индекс
            //Regex pasport = new Regex("^[0-9]{2}\\s[0-9]{2}\\s[0-9]{6}$"); // серия и номер паспорта
            //Regex phone_number = new Regex("^((\\+7)|8)9[0-9]{9}$");       // номер телефона
            //Regex group_number = new Regex("^[1-4][1-4]((Л|В|Б|Ю)|Пр?)$"); // номер группы 1 корпуса
            //Regex password = new Regex("(?=.*[A-Z])(?=(.*[a-z]){3,})(?=(.*[0-9]){2,})(?=.*[!№;:?@#$%^&*()',.])[0-9A-Za-z!№;:?@#$%^&*()',.]{8,}"); // пароль, где более 1 заглавная более 3 прописных более 2 цифр и минимум 1 спец символ

            //Console.WriteLine(r.Match("579705"));
            //Console.WriteLine(pasport.Match("22 16 579705"));
            //Console.WriteLine(phone_number.Match("+79677135776"));
            //Console.WriteLine(group_number.Match("11Пр"));
            //Console.WriteLine(password.Match("123qwertY"));

            //Match m = password.Match(Console.ReadLine());
            //string[] grname = password.GetGroupNames();
            //int[] sdgs = password.GetGroupNumbers();
            //if (m.Success == false)
            //{
            //    foreach(var name in grname)
            //    {
            //        Group grp = m.Groups[name];
            //        Console.WriteLine("   {0}: '{1}'", name, grp.Value);
            //    }

            //}


            // ####################### Дата и время ##############################
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToString("g"));
            //TimeSpan ts = new TimeSpan(10, 15, 0);
            //dt += ts;
            //Console.WriteLine(dt.ToString("g"));
            //dt -= ts;
            //Console.WriteLine(dt.ToString("g"));

            //DateTime bd = new DateTime(2002, 2, 6, 0, 5, 0);
            //TimeSpan mylife = dt.Subtract(bd);
            //Console.WriteLine(mylife.ToString());
            //var totalYears = Math.Truncate(mylife.TotalDays / 365);
            //var totalMonths = Math.Truncate((mylife.TotalDays % 365) / 30);
            //var remainingDays = Math.Truncate((mylife.TotalDays % 365) % 30);
            //Console.WriteLine("{0} year(s), {1} month(s) and {2} day(s)", totalYears, totalMonths, remainingDays);

            // ####################### Коллекции и перечисления ##############################
            //DaysOfWeek dd = new DaysOfWeek();
            //Console.WriteLine(dd.ReturnNameDay());
            //Console.WriteLine(dd.ReturnCountDaysBetween());

            //string sometext = "Было хорошо было так легко Но на шею бросили аркан Солнечный огонь атмосферы бронь Пробивал но не пробил туман";
            //ArrayList list = new ArrayList();
            //String[] words = sometext.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (object o in words)
            //{
            //    list.Add(o);
            //}

            //foreach (object o in list)
            //{
            //    Console.WriteLine(o);
            //}

            //int[] arr = new int[] {5, 3, 5, 1, 6, 2, 4, 1, 2, 6, 2, 3, 0 };
            //Stack s = Zad3(arr);
            //foreach (object o in s)
            //{
            //    Console.WriteLine(o);
            //}

            //Random rand = new Random();
            //int n = 20, num = 0, num0 = 0, num1 = 1;
            //Hashtable HT = new Hashtable();
            //for (int i = 0; i < n; i++)
            //{                
            //    num = num1 + num0;
            //    num0 = num1;
            //    num1 = num;
            //    HT.Add(num, (char)rand.Next(0, 120));
            //}
            //ICollection IC = HT.Keys;
            //foreach (object o in IC)
            //{
            //    Console.WriteLine(o + " " + HT[o]);
            //}

            // ####################### Обобщенные типы ##############################
            //обобщенный метод
            //show(144);
            //show("привет");

            //обобщенный класс
            //GeneralClass<int> gcl = new GeneralClass<int>(2385); 
            //Console.WriteLine(gcl.ToString());

            //обобщенный наследуемый класс
            //OtherGenericClass<char> ch = new OtherGenericClass<char>('g'); // наследуемый обобщенный класс
            //Console.WriteLine(ch.ToString());
            //JustClass j = new JustClass(50); //наследуемый обычный класс
            //Console.WriteLine(j.ToString());

            //обобщенный интерфейс
            //ForInterGen<bool> bobo = new ForInterGen<bool>(); //наследуемый обобщенный класс
            //Console.WriteLine(bobo.ShowMe(false));
            //JustForInterGen jojo = new JustForInterGen(); //наследуемый обычный класс
            //Console.WriteLine(jojo.ShowMe("Yare yare daze"));

            //обобщенный делегат
            //Del1<int, int, double> d1 = j.InStep;
            //Del1<double, double, int> d2 = j.Summ;
            //Del1<char, char, string> d3 = j.Concat;
            //Console.WriteLine(d1(5, 2));
            //Console.WriteLine(d2(10.5, 14.5));
            //Console.WriteLine(d3('H', 'i'));

            // ####################### Обобщенный список ##############################
            //List <User> Users = new List<User>();
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    while(sr.EndOfStream != true)
            //    {
            //        string[] str = sr.ReadLine().Split(';');
            //        Users.Add(new User() { f = str[0], i = str[1], o = str[2], gender = Convert.ToChar(str[3]), birth = Convert.ToDateTime(str[4])});
            //    }                
            //}
            //ShowList(Users);

            ////новые списки
            //List<User> ListM = Users.Where(x => x.gender == 'м').ToList();
            //Console.WriteLine("\n\t\tСписок мужчин");
            //ShowList(ListM);
            //Console.WriteLine("\n\t\tСписок женщин старше 21");
            //List<User> ListWOlderThan21 = Users.Where(x => x.birth.Year <= 2000 && x.gender == 'ж').ToList();
            //ShowList(ListWOlderThan21);
            //Console.WriteLine("\n\t\tСписок младше 21");
            //List<User> ListYoungerThan21 = Users.Where(x => x.birth.Year >= 2000).ToList();
            //ShowList(ListYoungerThan21);

            ////объединение, пересечение и разность списков
            //Console.WriteLine("\n\t\tСписок мужчины минус младше 21");
            //List<User> List1 = ListM.Except(ListYoungerThan21).ToList();
            //ShowList(List1);
            //Console.WriteLine("\n\t\tСписок мужчины объединить младше 21");
            //List<User> List2 = ListM.Concat(ListYoungerThan21).ToList();
            //ShowList(List2);
            //Console.WriteLine("\n\t\tСписок мужчины пересечение младше 21");
            //List<User> List3 = ListM.Intersect(ListYoungerThan21).ToList();
            //ShowList(List3);

            //string path1 = @"X:\subjects\МДК 01.01\ДляФайлов\list1.csv";
            //PrintToFile(path1, List1);

            // ####################### Работа с отладчиком ##############################
            //Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            //Debug.Listeners.Add(new TextWriterTraceListener(File.CreateText(path2)));
            //Debug.AutoFlush = true;
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(path2)));
            Trace.AutoFlush = true;
            Top10Quadr t10 = new Top10Quadr();
            //t10.ShowTop10Quadr();
            //Debug.WriteLine("Максимум");
            Trace.WriteLine("Максимум");
            t10.Max();
            //Debug.WriteLine("Сортировка");
            Trace.WriteLine("Сортировка");
            t10.Sort();            
            

            Console.ReadKey();
        }
        //метод записи списка в файл csv
        public static void PrintToFile(string path, List<User> L)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (User u in L)
                {
                    sw.WriteLine(u.f + ";" + u.i + ";" + u.o + ";" + Convert.ToString(u.gender) + ";" + Convert.ToString(u.birth));
                }
            }
        }
        //метод вывода содержимого списка с типов структуры
        public static void ShowList(List<User> u)
        {
            foreach (var v in u)
            {
                v.show();
            }
        }
        //методы для обобщенных типов (все три)
        public static void show<T>(T t1)
        {
            Console.WriteLine(t1);
        }

        public static void Fibom()
        {
            int n=20, num = 0, num0 = 0, num1 = 1;
            for (int i = 1; i < n; i++)
            {
                num = num1 + num0;
                num0 = num1;
                num1 = num;
            }
        }
        public static Stack Zad3(int[] arr)
        {
            int avg, sum=0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Stack st = new Stack();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= avg)
                {
                    st.Push(arr[i]);
                }
            }
            return st;
        }
    }
}

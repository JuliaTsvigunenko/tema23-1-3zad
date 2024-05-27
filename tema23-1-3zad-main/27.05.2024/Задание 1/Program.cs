using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {

        /// <summary>
        /// Перечисление месяцев 
        /// </summary>
        enum Mounth
        {
            Янаварь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Mounth.Янаварь);
            Console.WriteLine((int)Mounth.Янаварь);//0

            Console.WriteLine(Mounth.Февраль);
            Console.WriteLine((int)Mounth.Февраль);//1

            Console.WriteLine(Mounth.Март);
            Console.WriteLine((int)Mounth.Март);//2

            Console.WriteLine(Mounth.Апрель);
            Console.WriteLine((int)Mounth.Апрель);//3

            Console.WriteLine(Mounth.Май);
            Console.WriteLine((int)Mounth.Май);//4

            Console.WriteLine(Mounth.Июнь);
            Console.WriteLine((int)Mounth.Июнь);//5

            Console.WriteLine(Mounth.Июль);
            Console.WriteLine((int)Mounth.Июль);//6

            Console.WriteLine(Mounth.Август);
            Console.WriteLine((int)Mounth.Август);//7

            Console.WriteLine(Mounth.Сентябрь);
            Console.WriteLine((int)Mounth.Сентябрь);//8

            Console.WriteLine(Mounth.Октябрь);
            Console.WriteLine((int)Mounth.Октябрь);//9

            Console.WriteLine(Mounth.Ноябрь);
            Console.WriteLine((int)Mounth.Ноябрь);//10

            Console.WriteLine(Mounth.Декабрь);
            Console.WriteLine((int)Mounth.Декабрь);//11



            Console.ReadKey();
        }
    }
}

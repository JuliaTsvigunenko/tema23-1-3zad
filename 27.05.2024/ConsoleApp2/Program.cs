using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum Days
        {
            Понедельник, Вторник, Среда, Четверг, Пятнмица, Суббота, Воскресенье
        }


        static void Main(string[] args)
        {

            Days i;
            for (i = Days.Понедельник; i <= Days.Воскресенье; i++)
                Console.WriteLine(i + " имеет значение " + (int)i);
            Console.Read();


            Console.ReadKey();
        }
    }
}
    


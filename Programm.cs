using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Programm
    {
        static void Main(string[] args)
        {
            Edition ed = new Edition("Муму", "Иван Тургенев", 1852);
            ed.ShowInfo();
            ed.Info();
            Edition ed1 = new Edition("", "", -7);
            ed1.ShowInfo();
            Console.ReadKey();
        }
    }
}

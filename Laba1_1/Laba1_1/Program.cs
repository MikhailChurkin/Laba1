using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Laba1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar ObjTovar = new Tovar();
            Console.WriteLine(ObjTovar);
            Tovar oobTovar = new Tovar("Asus",2,165);
            Console.WriteLine(oobTovar);
            Console.ReadKey();
        }
    }
}

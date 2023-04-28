using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeslaX teslax = new TeslaX(1,2,"teslax",80);
            teslax.Drive();
            Console.WriteLine();
            Tesla tesla = new  Tesla(1, "tesla", 70);
            tesla.Drive();
            Console.WriteLine();
            TeslaY teslay = new TeslaY(1, 20000, "teslay", 100);
            teslay.Drive();
            Console.ReadLine();
        }
    }
}

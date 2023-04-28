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
            TeslaX teslax = new TeslaX(1,2,"teslax",3);
            teslax.Drive();
            
        }
    }
}

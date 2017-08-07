using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ILRepackTest.Lib1;
using ILRepackTest.Lib2;

namespace ILRepackTest.App
{
    class Program
    {
        static void Main(string[] args)
        {
            CLib1 l1 = new CLib1();
            CLib2 l2 = new CLib2();
            Console.WriteLine(l1.S);
            Console.WriteLine(l2.S);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1 : Interface1, Interface2
    {
        public Class1(Interface1 interface1)
        {
            
        }
        public int test()
        {
            var a = test2();
           Console.WriteLine(a*3);
        }

        public float test2()
        {
            return 0;
        }

        public void test3()
        {
          
        }
    }
}

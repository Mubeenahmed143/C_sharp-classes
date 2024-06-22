using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
    internal class sTUDENT
    {
        public sTUDENT()
        {
            Console.WriteLine("welcome to the constructor");
        }
        public sTUDENT(int pay , string name)
        {
            Console.WriteLine(pay + name);
        }

        ~sTUDENT()
        {
            Console.WriteLine("clean");
        }

    }
}

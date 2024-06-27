using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
    internal class Visit
    {
        public void eating()
        {
            Console.WriteLine("breakfast");
        }
        public void eating(string lunch)
        {
            Console.WriteLine("lunch");
        }
        public void eating(int dinner)
        {
            Console.WriteLine("dinner");
        }
    }
}

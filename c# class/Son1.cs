using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
    internal class Son1:Father
    {
        override
        public void relate()
        {
            Father.age = 45;
            Father.barcode = 444;
        

            base.relate();
            Console.WriteLine("I am a big son");
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
    internal class Father
    {
        public virtual void relate()
        {
            Console.WriteLine("I am a Father ");
        }

        /// overload ///
        public static int age;
        protected static int barcode;
        private static int pincode;
    }
}

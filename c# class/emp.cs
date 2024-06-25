using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
    internal class Student
    {

        public int id;

        public Student(int id)
        {
            this.id = id;

            Console.WriteLine("const" + id);
        }

        public void abc()
        {
            Console.WriteLine("method");
        }
        ~Student()
        {
            Console.WriteLine("clean");
        }

    }
}
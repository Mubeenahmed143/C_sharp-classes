using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
    internal class Car
    {

        int Car_number;
        int Car_price;
        string Car_name;
        string Car_owner;

        public void details( int price, string name, string owner)
        {
            //this.Car_number = num;
            this.Car_price = price;
            this.Car_name = name;
            this.Car_owner = owner;

            Console.WriteLine( price + name + owner);


        }

        public void speed(int r)
        {
            Console.WriteLine(r);
        }

        public void model()
        {
            Console.WriteLine("2024");
        }
        public void start()
        {
            Console.WriteLine("parent class");
        }
    }
}

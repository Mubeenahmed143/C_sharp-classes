using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{
	internal class Calculator
	{
		public delegate int calculator(int num1, int num2);

		public static int add(int a, int b)
		{
			return (a + b);
		}
		public static int sub(int x , int y)
		{
			return (x - y);
		}
		public static int mul(int m , int n)
		{
			return (m * n);
		}
		public static void div(int i , int j)
		{
            Console.WriteLine(i / j );
        }
	}
}

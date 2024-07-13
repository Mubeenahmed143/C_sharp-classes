// See https://aka.ms/new-console-template for more information
using c__class;

using System.Collections;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

//double a = 20000;
//double b = 40000;
//int formula;
//int a_convert = Convert.ToInt32(a);
//int b_convert = Convert.ToInt32(b);
//formula = a_convert*a_convert + b_convert*b_convert + 2*a_convert*b_convert;
//Console.WriteLine(formula);
//Console.Write(formula);


//string c = "500";

//int convert = Convert.ToInt32(c);

//Console.WriteLine(convert);

////////////////////////////////////////////////////////////////////////////////////////

//double pie = 3.142;

//Console.WriteLine("Please enter the value of radius");

//int r = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter the value of height");

//int h = Convert.ToInt32(Console.ReadLine());

//double cylinder;

//cylinder = pie * r * r * h;
//Console.WriteLine("The value of cylinder is =" + cylinder);

//////////////////////////////////////////////////////////////////////////

//Console.WriteLine("value of centigrade");
//double cent = Convert.ToInt32(Console.ReadLine());
//double answer;

//answer = cent + 273;
//Console.WriteLine(answer);

///////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your age");
//int age =Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Enter your Gender");
//char gender = Convert.ToChar( Console.ReadLine());

//Console.WriteLine("Enetr your Salary");
//double salary = Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Your Name is : " + name);
//Console.WriteLine("Your Age is : " + age);
//Console.WriteLine("Your Gender is : " + gender);
//Console.WriteLine("Your Salary is : " + salary);

//Console.WriteLine("Enter your City");
//string city = Console.ReadLine();

//Console.WriteLine("Enter your Age");
//int age =Convert.ToInt32(Console.ReadLine());

/////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Enter Pakistani Rupee");
//decimal pkr = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("What currency to convert to?");
//string currency = Console.ReadLine();

//decimal dollar = 270;

//decimal euro = 301;

//decimal ind = 3;

//decimal riyal = 74;

//if (currency == "dollar")
//{
//    decimal d_to_pak = pkr / dollar;
//    Console.WriteLine("Pakistani Rupee convert to Dollar (" + d_to_pak + ")");
//}
//else if (currency == "euro")
//{
//    decimal e_to_pak = pkr / euro;
//    Console.WriteLine("Pakistani Rupee convert to Euro (" + e_to_pak + ")");
//}
//else if (currency == "indian")
//{
//    decimal i_to_pak = pkr / ind;
//    Console.WriteLine("Pakistani Rupee convert to Indian Rupee (" + i_to_pak + ")");
//}
//else if (currency == "riyal")
//{
//    decimal r_to_pak = pkr / riyal;
//    Console.WriteLine("Pakistani Rupee convert to Riyal (" + r_to_pak + ")");
//}
//else
//{
//    Console.WriteLine("Something went wrong 'try again'");
//};

/////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//switch(num)
//{
//    case 10:
//        Console.WriteLine("your number is 10");
//        break;
//    case 20:
//        Console.WriteLine("your number is 20");
//        break;
//    case 30:
//        Console.WriteLine("your number is 30");
//        break;
//    default:
//        Console.WriteLine("enter only 10, 20, 30");
//        break;

//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Coffee with Karan");

//int Coffee_Cost = 0;

//Start:

//Console.WriteLine("Select your Coffee Cup Size");
//Console.WriteLine("1-Small , 2-Medium , 3-Large");

//int Cup_Size = int.Parse(Console.ReadLine());

//switch(Cup_Size)
//{
//    case 1:
//        Coffee_Cost += 50;
//        break;

//    case 2:
//        Coffee_Cost += 100;
//        break;

//    case 3:
//        Coffee_Cost += 150;
//        break;

//    default:
//        Console.WriteLine("Your choice {0} is Invalid", Cup_Size);
//        goto Start;
//}

//Decide:;

//Console.WriteLine("Do you want to buy another Coffee - {Yes or No}");
//String Decision = Console.ReadLine();

//switch(Decision.ToUpper())
//{
//    case "YES":
//        goto Start;

//    case "NO":
//        break;

//    default:
//        Console.WriteLine("Your Choice {0} is Invalid Try Again ", Decision);
//        goto Decide;
//}

//Console.WriteLine("Thankyou for shopping with us");
//Console.WriteLine("Bill Amount = ${0}", Coffee_Cost);

//Console.ReadKey();

//Console.WriteLine("Table of 2");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("2 * " + i + " = " + 2 * i);
//}

//Console.WriteLine("Even or Odd Numbers");

//for (int a = 1; a <= 50; a++)
//{
//    if(a % 2 == 0)
//    {
//        Console.WriteLine(a + " is Even Number");
//    }
//    else
//    {
//        Console.WriteLine(a + " is Odd Number");
//    }
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("WHILE LOOP");

//Console.WriteLine("Please enter your Age");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your pocket money");
//int counter = int.Parse(Console.ReadLine());

//while  (counter <= 850 && age>=18)
//{
//    Console.WriteLine(counter);
//    counter = counter + 1;
//}

///////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("WHILE LOOP WITH if else condition");

//int i, cus;

//Console.WriteLine("Let's play the game");
//Console.WriteLine("You have only 3 attempts");
//int a = 0;
//i = 13;
//cus = 0;


//while (i != cus && a != 4)
//{
//    if (a == 4)
//    {

//        Console.WriteLine("you exceed the limit");

//    }
//    Console.WriteLine("Enter the number between 1 to 20");
//    cus = Convert.ToInt32(Console.ReadLine());

//    else if (cus < i)
//    {



//        Console.WriteLine("Number is too low");
//    }
//    else if (cus > i)
//    {



//        Console.WriteLine("Number is too high");
//    }
//    else
//    {
//        Console.WriteLine("Congratulations! You won the Game");
//        break;
//    }


//    a++;


//}

//Console.WriteLine("Sorry! you failed");

//string userChoice = string.Empty;

//do
//{
//    Console.WriteLine("enter your target?");
//    int userTarget = int.Parse(Console.ReadLine());

//    int counter = 10;
//    //Console.WriteLine("tra again");

//    while(counter<=userTarget)
//    {
//        Console.WriteLine(counter + " ");
//        counter = counter + 1;
//    }
//    do
//    {
//        Console.WriteLine("Do you want to continue - Yes or No?");
//        userChoice = Console.ReadLine().ToUpper();
//    }
//    while (userChoice != "YES" && userChoice != "NO");

//}
//while (userChoice == "YES");

////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Array and array with for each and for loop");

//int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(i + " . " + a[i]);
//}


//foreach (int i in a)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine(a[4]);


//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(a[6]);
//}


//int[] myarray = new int[6];
//myarray[0] = 1;
//myarray[1] = 2;
//myarray[2] = 3;
//myarray[3] = 4;
//myarray[4] = 5;
//myarray[5] = 6;

//foreach (int i in myarray)
//{
//    Console.WriteLine(i);
//}


//int[] myarray = new int[3];

//Console.WriteLine("enter the value of array");
//for (int i = 0; i < myarray.Length; i++)
//{
//    myarray[i] = Convert.ToInt32(Console.ReadLine());

//}

//Array.Sort(myarray);
//Array.Reverse(myarray);

//foreach (int i in myarray)
//{
//    Console.WriteLine("Output " + i);
//}

//Console.WriteLine("2-DIMENSIONAL ARRAY");

//int[,] a = new int[4,4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };


//for (int i = 0; i < 4;  i++)
//{
//    Console.WriteLine("Row : " + i) ;
//    for(int j = 0; j < 4; j++)
//    {
//        Console.WriteLine("Column : " + j);
//        Console.WriteLine("Elements of 2d-Array : " + a[i, j]);
//    }
//}

//Console.WriteLine("multidimensional array with user input");

//Console.WriteLine("User input 2D-Array/Multi Dimensional Array");
//int[,] matrix = new int[4, 4];

//for (int row = 0; row < 4; row++)
//{
//    for (int col = 0; col < 4; col++)
//    {

//        Console.Write("Enter value for matrix [{0}, {1}] =", row, col);
//        matrix[row, col] = (int)Convert.ToInt32(Console.ReadLine());
//    }
//}

//Console.WriteLine("Your Matrix is : ");
//for (int row = 0; row < 4; row++)
//{
//    for (int col = 0; col < 4; col++)
//    {
//        Console.Write(matrix[row, col] + " ");
//    }
//    Console.WriteLine();
//}

///////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Jagged ARRAY with user input");

//int[][] jag = new int[4][];

//for(int z = 0; z < 4; z++)
//{
//    jag[z] = new int[4];
//}

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4
//        ; j++)
//    {
//        Console.WriteLine("Enter value of matrix at position [" + i + "][" + j + "]:");
//        jag[i][j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//for (int a = 0; a<jag.Length; a++)
//{
//    for (int b = 0; b < jag[a].Length; b++)
//    {
//        Console.Write(jag[a][b] + " ");
//    }
//    Console.WriteLine();
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Class and Methods");

//Car mehran = new Car();

//Console.WriteLine("car details");
//mehran.details(1200000, "Toyota", "sheikh sahab");

//Console.WriteLine("speed");
//mehran.speed(240);

//Console.WriteLine("model");
//mehran.model();

/////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("constructor and destructor");

//sTUDENT s1 = new sTUDENT();
//sTUDENT s2 = new sTUDENT(34, "sahab");

///////////////////////////////////////////////////////////////

//Console.WriteLine("Inheritance");

//CarChild c1 = new CarChild();
//c1.child_speed();
//c1.start();

//Console.WriteLine(".");
//Car C2 = new Car();
//C2.start();

//Console.WriteLine(".");
//g_child g1 = new g_child();
//g1.child_speed();
//g1.start();
//g1.corolla();

///////////////////////////////////////////////////////////////////////////

//static void merafunction()
//{

//    Student s1 = new Student(45);
//    Student s2 = new Student(45);



//}

//merafunction();
//GC.Collect();
//GC.WaitForPendingFinalizers();

//////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("2nd Pillar Polymorphism");

//Console.WriteLine("override method");
//Son1 s1 = new Son1();
//s1.relate();

//Console.WriteLine("overload method");
//Visit v1 = new Visit();
//v1.eating();
//v1.eating("Biryani");
//v1.eating(2);

///////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Encapsulation");

//Father.age = 44;

//////////////////////////////////////////////////////////////////////
////////////Console.WriteLine("Abstraction ");///////////////////
///
//Senior_Emp s1 = new Senior_Emp();

///////////////////Console.WriteLine("Interface");///////////////////////////////
///
//Onedown_Sol m1 = new Onedown_Sol();

/////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////Console.WriteLine("Indexers");/////////////////////////////////////////////

//IndexerClass std = new IndexerClass();
//std[0] = "Mubeen";
//std[1] = "Murtaza";
//std[2] = "Zaid";
//std[3] = "Hanif";
//std[4] = "Hassan";

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(std[i]);
//}

//IndexerClass sal = new IndexerClass();
//sal[0, 0] = 33000;
//sal[1, 1] = 44000;
//sal[2, 2] = 55000;
//sal[3, 3] = 66000;

//for (int j = 0; j < sal[1,1]; j++)
//{
//    for (int k = 0; k < j; k++)
//    {
//        Console.WriteLine(sal[k,j]);
//    }

//}

////////////////////////////////////////////////////////////////////////
/////////////////Console.WriteLine("parameters type");//////////////////////

//public class Example
//{

//   //////Value parameter example////

//    public void DisplayValue(int x)
//    {
//        Console.WriteLine("Value: " + x);
//    }
//    ///Refrence parameter example///
//    public void Increament(ref int x)
//    {
//        x++;
//    }

//    ///Output parameter example///
//    public void GetValues(out int x,out int y)
//    {
//        x = 10;
//        y = 20;
//    }
//}

//Example e = new Example();
//e.DisplayValue(8);
//e.Increament(4);
//e.GetValues(33.55);

////////////////////////////////////////////////////////

//////Console.WriteLine("Collections");/////

//ArrayList movies = new ArrayList();

//movies.Add("Pathan");
//movies.Add("Jawan");
//movies.Add(1920);
//movies.Add("pk");
//movies.Add("DDLJ");

//movies.Insert(2, "pk");

//movies.Remove("pk");
//movies.RemoveAt(2);

//foreach (var a in movies)
//{
//    Console.WriteLine(a);
//}

//Console.WriteLine();

///////////////////////////////////////////////////'
///Console.WriteLine("Exception (Error Handling)");///

///Exception///
//try
//{
//    int aa = 90;
//    int bb = 40;
//    int cc = aa + bb;
//    Console.WriteLine(cc);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex);
//}
//Console.WriteLine(" ");
/////Arithmetic Exception///
//try
//{
//    int a = 90;
//    int res = a / 0;
//    Console.WriteLine(res);
//}
//catch (ArithmeticException abc)
//{
//    Console.WriteLine(abc);
//}
//Console.WriteLine(" ");
/////Invalid Cast Exception///
//try
//{
//    float f = 23.4f;
//    object o = f;
//    int b = (int)o;
//    Console.WriteLine(b);
//}
//catch(InvalidCastException ix)
//{
//    Console.WriteLine("Message: {0}", ix.Message);
//    Console.WriteLine("Error: {0}", ix);
//}
//Console.WriteLine(" ");
/////Array Type Mismatch ///

//try
//{
//    string[] names = { "Mubeen", "Murtaza", "Zaid" };
//    int[] id = new int[3];
//    names.CopyTo(id, 0);
//}
//catch(ArrayTypeMismatchException am)
//{
//    Console.WriteLine("Message:  {0}",am.Message);
//    Console.WriteLine("Error: {0}",am);
//}
//Console.WriteLine(" ");
/////(Index_out_of_range)///
//try
//{
//    string[] actors = new string[] { "Mubeen", "Murtaza", "Zaid" };
//    Console.WriteLine(actors[4]);
//}
//catch(IndexOutOfRangeException rx)
//{
//    Console.WriteLine("Message: {0}",rx.Message);
//    Console.WriteLine("Error: {0}",rx);
//}
//Console.WriteLine(" ");
/////Overflow Exception///
//byte numOne = 200;
//byte numTwo = 6;
//byte result = 0;
//try
//{
//    result = checked((byte)(numOne * numTwo));
//    Console.WriteLine("Result = {0}", result);
//}
//catch(OverflowException objx)
//{
//    Console.WriteLine("Error Description: {0}", objx.ToString());
//    Console.WriteLine("Exception: {0}",objx.GetType());
//    Console.WriteLine("Message: {0}",objx.Message);
//    Console.WriteLine("Source: {0}", objx.Source);
//    Console.WriteLine("TargetSite: {0}", objx.TargetSite);
//    Console.WriteLine("StackTrace: {0}", objx.StackTrace);
//}

//namespace Students
//{
//    class Meri
//    {
//        public Meri()
//        {
//            Console.WriteLine("Students");
//        }
//    }

//    namespace Examination
//    {
//        class Meri
//        {
//            public Meri()
//            {
//                Console.WriteLine("Exam");
//            }
//            static void Main(string[] args)
//            {
//                Meri bv = new Meri();

//                Students.Meri aaa = new Students.Meri();

//            }
//        }
//    }
//}

////////////////////////////////////////////////////////////////////////////////////

///Console.WriteLine("Delegates");////
///
//Calculator.calculator cal = new Calculator.calculator(Calculator.add);
//Console.WriteLine("Addition : " + cal(25, 6));

//Calculator.calculator c_sub = new Calculator.calculator(Calculator.sub);
//Console.WriteLine("Subtraction : " + c_sub(25, 6));

//Calculator.calculator c_mul = new Calculator.calculator(Calculator.mul);
//Console.WriteLine("Multiplication : " + c_mul(25, 6));

////Error aae ga//
//Calculator.calculator c_div = new Calculator.calculator(Calculator.div);
//Console.WriteLine("Divition : " + c_mul(25, 6));

///////////////////////////////////////////////////////////////
///Console.WriteLine("Events & Delegates");///

namespace @event // Namespace declaration
{
	public class mycar
	{
		// Define a delegate for the event
		public delegate void speedcar();

		// Define the event based on the delegate
		public event speedcar speedup;

		public int speed = 0;

		public void drive()
		{
			for (int i = 0; i < 20; i++)
			{
				if (i >= 10)
					speedup(); // Invoke the event if subscribed  //?.Invoke()//
				speed += i;
				Console.WriteLine("current speed " + i);  // <-speed//
				System.Threading.Thread.Sleep(500);
			}
		}

		// Static method to handle the event
		public static void Mm_carmoved()
		{
			Console.WriteLine("car has exceeded the limit");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			mycar mm = new mycar();

			// Subscribe to the event with the static method
			mm.speedup += new mycar.speedcar(mycar.Mm_carmoved);

			// Start driving
			mm.drive();
		}
	}
}
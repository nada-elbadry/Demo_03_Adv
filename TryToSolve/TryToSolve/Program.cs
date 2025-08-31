using System.Runtime.Intrinsics.Arm;
using TryToSolve.Part01;
using TryToSolve.Part02;

namespace TryToSolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Console.WriteLine(Calculator.Add(1, 2));
            //Console.WriteLine(Calculator.Add(1, 2, 3));
            //Console.WriteLine(Calculator.Add(10.5, 5)); 
            #endregion

            #region  Q02
            //Rectangle r1 = new Rectangle();
            //Rectangle r2 = new Rectangle(4, 5);
            //Rectangle r3 = new Rectangle(7);
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            #endregion

            #region  Q03
            //Complex c1 = new Complex() { Real = 2, Img = 5 };
            //Complex c2 = new Complex() { Real = 4 , Img = 3 };
            //Complex sum=  c1 + c2;
            //Complex diff = c1 - c2;
            //Complex? C3 = default;
            //Console.WriteLine($"Diffrence = {diff}");
            //Console.WriteLine($"Sum ={sum}");
            //Console.WriteLine($"C1 = {c1}");

            //Console.WriteLine($"C3 after pretfex the c1 {C3 = ++c1}");
            //Console.WriteLine($"C3 after pretfex the c1 {C3 = c1++}");

            //if (c1 > c2)
            //    Console.WriteLine("C1>C2");
            //else if (c1 < c2)
            //    Console.WriteLine("C2>C1");
            //else
            //    Console.WriteLine("C1==C2");
            //    string message = c1 > c2 ? "C1>C2" : "C1<C2"; 
            #endregion

            #region   Q04
            //Employee emp = new Employee();
            //emp.Works();
            //Console.WriteLine("======================");
            //Manger manger = new Manger();
            //manger.Works();
            //Console.WriteLine("======================");
            //Employee emp2 = new Manger();
            //emp2.Works(); 
            #endregion

            #region   Q05
            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();
            //Console.WriteLine("=================");
            //BaseClass der01 = new DerivedClass1();
            //der01.DisplayMessage();
            //Console.WriteLine("======================");
            //BaseClass dr02 = new DerivedClass2();
            //dr02.DisplayMessage();
            //DerivedClass2 dr03 = new DerivedClass2();
            //dr03.DisplayMessage(); 
            #endregion

            #region Part 02
            DurationTo D1a = new DurationTo(1, 10, 15);
            Console.WriteLine(D1a);

            DurationTo D1b = new DurationTo(3600);
            Console.WriteLine(D1b); // Hours: 1, Minutes :0, Seconds :0

            DurationTo D2 = new DurationTo(7800);
            Console.WriteLine(D2);  // Hours: 2, Minutes :10, Seconds :0

            DurationTo D3 = new DurationTo(666);
            Console.WriteLine(D3);  // Minutes :11, Seconds :6

          
            DurationTo D1 = new DurationTo(1, 10, 15);
            DurationTo D4 = D1 + D2;
            Console.WriteLine(D4);

            DurationTo D5 = D1 + 7800;
            Console.WriteLine(D5);

            DurationTo D6 = 666 + D5;
            Console.WriteLine(D6);

            DurationTo D7 = ++D1;
            Console.WriteLine(D7);

            DurationTo D8 = --D2;
            Console.WriteLine(D8);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            Console.WriteLine(D1 > D2);
            Console.WriteLine(D1 <= D2);

            if (D1) Console.WriteLine("D1 is positive");

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt);

            #endregion
        }
    }
}

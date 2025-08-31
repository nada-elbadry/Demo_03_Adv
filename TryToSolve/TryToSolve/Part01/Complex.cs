using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToSolve.Part01
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Img { get; set; }

        public static Complex operator +(Complex left, Complex rigth)
        {
            Complex result = new Complex()
            {
                Real = (left?.Real??0) + (rigth?.Real??0),
                Img = (left?.Img??0) + (rigth?.Img??0)

            };
            return result;
        }

        public static Complex operator -(Complex lift, Complex right)
        {
            return new Complex()
            {
                  Real = (lift?.Real??0) - (right?.Real??0),   
                  Img= (lift?.Img??0) - (right?.Img??0)

            };

        }
        public static Complex operator ++ (Complex c)
        {
            if (c is not null)
                return new Complex()
                {
                    Real = (c?.Real ?? 0) + 1,
                    Img = c?.Img ?? 0
                };
            else return new Complex();

        }

        public static Complex operator --(Complex c)
        {
            if (c is not null)
                return new Complex() { Real =(c?.Real??0)-1,Img = c?.Img??0 };
            else
                return new Complex();

        }

        public static bool operator > (Complex left , Complex right)
        {
            //Left.Real > right.Real =>True
            //Left.Real < right.Real =>False
            //Left.Real == right.Real =>
            //Left.Img > right.Img =>True
            //Left.Img > right.Img =>False

            if (left?.Real == right?.Real)
                return left?.Img > right?.Img;
            else
                return left?.Real > right?.Real;
        }
        public static bool operator < (Complex left , Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Img > right?.Img;
            else
                return left?.Real < right?.Real;
        }
        public override string ToString()
        {
            return $"Real = {Real},Img = {Img}";
        }
    }
}

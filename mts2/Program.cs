using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;
    class Number
    {
        readonly int _number;
        public Number(int number)
        {
            _number = number;
        }
        public override string ToString()
        {
            return _number.ToString(_ifp);
        }
        public static string operator +(Number a, Number b)
        {
            return (new BigInteger(a._number)+ new BigInteger(b._number)).ToString(_ifp);
        }
        public static string operator +(Number a, string b)
        {
            if (BigInteger.TryParse(b, out BigInteger _b))
            {
                return (new BigInteger(a._number) + _b).ToString(_ifp);
            }
            else throw new Exception("It is impossible to fold");
        }
        public static implicit operator string(Number v)
        {
            return v.ToString();
        }
    }
    static void Main(string[] args)
    {
        int someValue1 = 10;
        int someValue2 = 5;
        string result = new Number(someValue1) + someValue2.ToString(_ifp);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}

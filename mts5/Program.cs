using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        TransformToElephant();
        NextCode();
        Console.WriteLine("Муха");
        //... custom application code
        static void NextCode()
        {
            Console.WriteLine("Пропустили Муху");
            Environment.Exit(0);
        }
    }
    static void TransformToElephant()
    {
        //... write your code here
        Console.WriteLine("Слон");
    }
}
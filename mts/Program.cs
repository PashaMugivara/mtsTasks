using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
            Console.WriteLine("Failed to fail process!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
    static void FailProcess()
    {
        throw new Exception("My Exception");
    }
}
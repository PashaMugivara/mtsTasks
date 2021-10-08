using System;
class Program
{
    struct IntValue
    {
        private int? _value;
        public int? Value { get { HasValue = _value.HasValue; return _value; } set { _value = value; } }
        public bool HasValue;
    }
    static void Main(string[] args)
    {
        IntValue intValue = new IntValue();
        Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);
        intValue.Value = 1;
        Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);
        intValue.Value = -1;
        Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);
        intValue.Value = 0;
        Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);
        intValue.Value = null;
        Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);
        Console.ReadKey();
    }
}
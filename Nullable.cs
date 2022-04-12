using System;

public class UseNullable
{
    public static void Main(string[] args)
    {
        int? num = null; //declaring nullable type
		double? num1 = new double?(5.5);
		Console.WriteLine("value is {0}.", num);
		Console.WriteLine("value is {0}.", num1);
		double num2 = num1?? 2.5;   //null coalescing if num1 is null set value to 2.5 otherwise num1
		Console.WriteLine("value is {0}.", num2);
		num1 = null;
		num2 = num1?? 2.5;
		Console.WriteLine("value is {0}.", num1);
		Console.WriteLine("value is {0}.", num2);
    }
}

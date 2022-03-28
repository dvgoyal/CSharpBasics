using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[7]{1, 2, 3, 4, 5, 6, 7};
        var numQuery = 
            from num in arr
            where (num%3)==0
            select num;
            
        foreach(int num in numQuery)
            Console.Write("{0} ", num);
        
        int count = numQuery.Count();
        Console.WriteLine("{0}", count);
    }
}
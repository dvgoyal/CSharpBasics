using System;
using System.Collections.Generic;

public class Program{
    public static void Main(){
        List<int> mylist = new List<int>();
        for(int i=1; i<=10; i++)
            mylist.Add(i);
           
        Console.WriteLine("using foreach loop");
        foreach(int num in mylist)
            Console.Write("{0} ", num);
        Console.WriteLine(" ");
          
        Console.WriteLine("using index");
        for(int i = 0; i< mylist.Count; i++)
            Console.Write("{0} ", mylist[i]);
        Console.WriteLine(" ");
        
        Console.WriteLine("removing 4 from list");
        mylist.Remove(4); 
        foreach(int num in mylist)
            Console.Write("{0} ", num);
        Console.WriteLine(" ");
        
        
        Console.WriteLine("removing element at index 2 from list");
        mylist.RemoveAt(2); 
        foreach(int num in mylist)
            Console.Write("{0} ", num);
        Console.WriteLine(" ");
        
        Console.WriteLine("remove range elements in the list");
        mylist.RemoveRange(4, 3);  //index, count
        foreach(int num in mylist)
            Console.Write("{0} ", num);
        Console.WriteLine(" ");
        Console.WriteLine("Count of Elements = {0}", mylist.Count);
        
        Console.WriteLine("remove all elements in the list");
        mylist.RemoveAll(x=> x%3==0); 
        foreach(int num in mylist)
            Console.Write("{0} ", num);
        Console.WriteLine(" ");
        Console.WriteLine("Count of Elements = {0}", mylist.Count);
        
        Console.WriteLine("clear the list");
        mylist.Clear();
        Console.WriteLine("Count of Elements = {0}", mylist.Count);
    }
}

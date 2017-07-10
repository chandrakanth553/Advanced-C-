using System;

namespace Advanced_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDelgates genericDelgates = new GenericDelgates();
            //Generic Delegate which return type is VOID
            Action<String> action = new Action<String>(genericDelgates.ActionMethod);
            action("Chandu");
            //Generic Delegate which has return type
            Func<int , int , int> func = new Func<int , int , int>(genericDelgates.Addition); 
            System.Console.WriteLine(func(10,20));
            //Generic Delegate which return type is Boolean
            Predicate<String> predicate = new Predicate<String>(genericDelgates.condtion);
            System.Console.WriteLine(predicate("Chandu"));
        }
    }
}

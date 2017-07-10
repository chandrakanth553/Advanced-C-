using System;

namespace Advanced_C_
{
    class Program
    {
        public delegate int MyDel (int x, int y);
        public delegate void Multicast(String S);
        static void Main(string[] args)
        {
            
            Delegates delegates = new Delegates();
            MyDel myDel = new MyDel(delegates.Add);
            System.Console.WriteLine(myDel(10,20));
            myDel = delegates.Multiply;
            System.Console.WriteLine(myDel(10,20));
            MultiCastDelegates multiCastDelegates = new MultiCastDelegates();
            //Multicast Delegates can work if return type is Void
            Multicast multicast = new Multicast(multiCastDelegates.Method1);
            multicast+=multiCastDelegates.Method2;
            multicast("Chandu");
        }
    }
}

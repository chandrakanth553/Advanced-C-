using System;

namespace Advanced_C_
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter A Number ");
           int Number = Convert.ToInt32(Console.ReadLine());
           try{
            if(Number <1 || Number >10){
                throw new CustomException();
           }
           }catch(CustomException){
               Console.WriteLine("Please Enter A number Between 1-10");
           }
           
        }
    }
}

using System;

namespace Advanced_C_{
    class ExceptionHandling{
        public void Addition(){
            Console.WriteLine("Please enter the first Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            try{
                int Result = FirstNumber/SecondNumber;
                System.Console.WriteLine("The Result is:"+Result);
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
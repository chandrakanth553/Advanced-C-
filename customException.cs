using System;

namespace Advanced_C_{
    class CustomException:Exception{
        public CustomException(){
            
        } 
        public CustomException(String Message):base(Message){

        }
        public CustomException(String Message, Exception Innerexception): base(Message, Innerexception){

        }
    }
}
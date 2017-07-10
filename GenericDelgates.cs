using System;

namespace Advanced_C_
{
    class GenericDelgate
    {
        public void ActionMethod(String S)
        {
            System.Console.WriteLine("It don't has return Type: "+S);
        }
        public int Addition(int a, int b){
            return a+b;
        }

        public bool condtion(String s){
            if(s=="Chandu"){
                return true;
            }else{
                return false;
            }
        }
    }
}
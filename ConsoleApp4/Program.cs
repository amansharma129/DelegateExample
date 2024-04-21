using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            myclass.MethodToCal(OtherFunctionToCall);
            Console.ReadLine();
        }
        public static void OtherFunctionToCall(int i)
        {
            Console.WriteLine(i);
        }
    }

    public class myclass
    {
        public delegate void myDel(int i);
        public static void MethodToCal(myDel obj)
        {
            //some long work
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
            }
        }
    }
}
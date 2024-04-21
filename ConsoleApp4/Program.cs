using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static ConsoleApp4.Program;

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
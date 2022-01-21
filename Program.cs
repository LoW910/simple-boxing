using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object BoxedData = "This is clearly a string";

            if(BoxedData is int) {
                System.Console.WriteLine("I guess we have an integer value in this box");
            }
            if (BoxedData is string) {
                System.Console.WriteLine("It is totally a string in the box!");
            }


            object actuallyString = "a string";
            string explicitString = actuallyString as string;

            // // THIS WON'T WORK!!
            // object actuallyInt = 256;
            // int explicitInt = actuallyInt as int;

            List<object> newObjectList = new List<object>();
            newObjectList.Add(7);
            newObjectList.Add(28);
            newObjectList.Add(-1);
            newObjectList.Add(true);
            newObjectList.Add("chair");

            System.Console.WriteLine(newObjectList);

            int num = 0;
            foreach (var obj in newObjectList)
            {
                System.Console.WriteLine(obj);
                if(obj is int) {
                    num += (int) obj;
                }
            }
            System.Console.WriteLine(num);














        }
    }
}

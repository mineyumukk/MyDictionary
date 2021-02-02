using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "one");
            myDictionary.Add(2, "two");
            myDictionary.Add(3, "three");
            myDictionary.Add(4, "four");


            myDictionary.Write();
            Console.ReadLine();


        }
    }
}

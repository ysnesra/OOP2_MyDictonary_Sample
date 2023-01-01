using System;
using System.Collections.Generic;

namespace OOP2_MyDictonary_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<TKey, TValue>      
            //**key olarak tanımladığımız index numarasına göre çağırırız  

            //plaka => (34: İstanbul), (35: İzmir)

            MyDictonary<int, string> cities = new MyDictonary<int, string>();
            cities.Add(34, "İstanbul");
            cities.Add(38, "Kayseri");
            cities.Add(35, "İzmir");
            cities.Add(41, "Kocaeli");

            Console.WriteLine(cities.MyLength);   //MyLength metotunu çağırırız

            cities.List();
       
        }
    }
}

using System;
using System.Collections.Generic;

namespace MyDictonary1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            Console.WriteLine(sehirler.Count);
     
            
            
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
        }

        class MyList<T>
        {
            T[]  _array;
            T[] _tempArray;
            
            public MyList() 
            {
                _array = new T[0];

            }

            public void Add(T items) 
            {

            }
 

            public int Count
            {
                get { return _array.Length; }
 
            }

        }
    }









}
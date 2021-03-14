using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> cities = new List<string>();
            Mylist<string> cities2 = new Mylist<string>();
            cities2.Add("İstanbul");
            cities2.Add("Ankara");
           
            cities2.Print();
            Console.WriteLine(cities2.MyCount); // 2 
        }



    }
        class Mylist<T> // Generic Class
    {
        T[] array;
        T[] tempArray; 
        public Mylist()
        {
            array = new T[0];
        }

        public void Add(T item)
        {


            tempArray = array ; 
            array = new T[array.Length + 1 ];
            for (int i = 0; i < tempArray.Length ; i++)
            {
                array[i] = tempArray[i]; 
            }
            array[array.Length - 1] = item;


        }
        public void Print()
        {

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
       

        public int MyCount
        {
            get { return array.Length; }
           
        }


    }



     
}


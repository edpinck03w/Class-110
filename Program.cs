using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var p = new Program();
            p.Test();
            string full = p.FullName("Edward", "Pinckney");
            Console.WriteLine(full);

            p.Exc1();
        }
        
        void Exc1(){
            var numbers = new List<int>();
            // 10 20 .. 1000

            for(int i=1; i<101; i++){
                numbers.Add(i * 10);
            }
            Console.WriteLine(numbers);

            var sum = 0;
            foreach(int num in numbers){
                if(num > 40) {
                    sum += num;
                }
            }

            //for(int j=0; j< numbers.Count; j++){
              //  sum += numbers[j];
            //}
            System.Console.WriteLine("Total: " + sum);

            NoReturns();
        }

        void NoReturns(){
            System.Console.WriteLine("test");

            //Variable types
            string name = "Edward";
            int age = 99;
            bool found = false;
            float f = 123.12f;
            decimal d = 123.123m;

            //string n = "98"; changing string format into numbers - just like the homework example
            //int res = int.Parse(n);

            string[] names = new string[100];
            names[0] = "asd";
            names[1] = "ep";

            //this creates a dynamic array without having to declares its size first - but you  need to add Line 2 above first to use it!
            List<string> list = new List<string>();
            list.Add("asdasd");


            System.Console.WriteLine("From array:" + name[0]);
            System.Console.WriteLine("From list:" + list[0]);

            
        }

        string FullName(string first, string last){
            return first + " " + last;
        }

        int Test(){
            Console.WriteLine("First method");
            return 1;
        }
    }
}

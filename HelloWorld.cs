using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    public class HelloWorld
    {
        /*public static void Main(string[] args)
        {
            var age = 25;
            Console.WriteLine("var holds TYPE:{0} | VAL:{1}", age.GetType(), age);
            var name = "Rebecca";
            Console.WriteLine("var holds TYPE:{0} | VAL:{1}", name.GetType(), name);

            int[] odds = new[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("var holds an array of numbers");

            foreach (var num in odds)
            {
                Console.WriteLine("TYPE:{0}|VAL:{1}", num.GetType(), num);
            }

            var p1 = new Person();
            p1.FirstName = "";
        }*/
        public class Person
        {
            public string FirstName
            {
                get => _firstName;
                set => _firstName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("First name must not be blank");
            }
            private string _firstName;
        }

    }
}


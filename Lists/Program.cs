using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace CollectionsClass

{
   
    public class Program
    {
        public static void Main()
        {
            var queue = new Queue<int>();
            Console.WriteLine("Count: {0}", queue.Count);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Count: {0}", queue.Count);
            // var iterator = queue.GetEnumerator();
            // while (iterator.MoveNext())
            // {
            //     Console.WriteLine(iterator.Current);
            //      Console.WriteLine("Count: {0}", queue.Count);
            // }

            var count = queue.Count;
            for (var v = 0; v < count; v++)
            {
                int val = queue.Dequeue();
                Console.WriteLine(val);
            }

            Console.WriteLine("Count: {0}", queue.Count);
            Console.ReadLine();
            List<string> avengers = new List<string>
        {
            "Iron Man",
            "Captian Marvel"
        };
            Predicate<string> match = x => x == "Captian Marvel";
            int index = avengers.FindIndex(match);
            Console.WriteLine(index);
            Console.WriteLine();
            Console.ReadLine();
            // bool Match(string obj)
            //{
            //    obj = "Iron Man";
            //    var a = true;

            //    foreach (var avenger in avengers)
            //    {
            //        a =  obj.Equals(avenger);
            //    }
            //    return a;
            //}
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(25);
            stack.Push(45);
            stack.Push(1644);
            var iterator = stack.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
                Console.WriteLine("Count: {0}", stack.Count);
            }
            Console.ReadLine();
            for (int i = 0; i < stack.Count; i++)
            {

            }
            // LOOKUPS
            var gotLineup = new List<Student>()
        {
            new Student(){LastName ="Stark", FirstName ="Robb", age = 40},
             new Student(){LastName ="Lannister", FirstName ="Sersei", age = 43},
            new Student(){LastName ="Stark", FirstName ="Sansa", age = 25},
            new Student(){LastName ="Lannister", FirstName ="Jamie", age = 43},
             new Student(){LastName ="Stark", FirstName ="Arya", age = 43},
            new Student(){LastName ="Lannister", FirstName ="Tyrion",age = 40},
        };


            var family = gotLineup.ToLookup(c => c.LastName);

            foreach (var group in family)
            {
                WriteLine(group.Key);
                WriteLine("==============");

                foreach (var subItem in group)
                {
                    WriteLine($"{subItem.LastName} {subItem.FirstName}");
                }

                WriteLine("\r");
            }


        }

        public class Student
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public int age { get; set; }
        }


    }





}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace C__exception_handling
{
    internal class Program
    {
        static void fun1()
        {
            for (int i = 0; i < 10000; i++)
            {

                Console.WriteLine("Function 1 = " + i);
                //Thread.Sleep(1000);
            }
        }

        static void fun2()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Function 2 = " + i);
                //Thread.Sleep(1000);
            }
        }

        static async void methodAsyncAwait()
        {
            await Task.Delay(50000);
            Console.WriteLine("Completed");
        }

        static void Main(string[] args)
        {
            Program.methodAsyncAwait();
            Console.WriteLine("Main thread");

            //Thread t1 = new Thread(new ThreadStart(fun1));
            //Thread t2 = new Thread(new ThreadStart(fun2));

            ////Task t1 = new Task(fun1);
            ////Task t2 = new Task(fun2);
            //t1.Start();
            //t2.Start();


            //Console.WriteLine("Hello world");
            Console.ReadLine();






            //var names = new List<string>() { "a", "b" };
            //names.Add("a");
            //names.Add("b");
            //names.Add("c");
            //names.Add("d");
            //;

            //names.Sort();
            //Console.WriteLine(names.Contains("a"));

            //var names = new HashSet<string>();
            //names.Add("Sonoo");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");
            //names.Add("Ankit");
            //names.Add("Ankit");

            //var names = new SortedSet<string>();
            //names.Add("Sonoo");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");
            //names.Add("Ankit");
            //names.Add("Ankit");       


            //var names = new LinkedList<String>();
            //names.AddFirst("a");
            //names.AddFirst("b");
            //names.AddLast("c");
            //LinkedListNode<string> node = names.Find("a");
            //names.AddAfter(node, "x");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("1", "A");
            //dic.Add("2", "B");
            //dic.Add("3", "C");
            //dic.Add("4", "D");
            //dic.Add("5", "E");

            //dic.Remove("1");

            //foreach (KeyValuePair<string, string> pair in dic)
            //{
            //    Console.WriteLine(pair.ToString());
            //}

            //SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            //names.Add("a", "b");
            //names.Add("c", "d");

            //var li = new List<string>(names.Values);

            //foreach (var name in li)
            //{
            //    Console.WriteLine(name);
            //}


            //foreach (KeyValuePair<string, string> kv in names)
            //{
            //    Console.WriteLine(kv.ToString());
            //}


            //Console.ReadLine();



        }

    }
}

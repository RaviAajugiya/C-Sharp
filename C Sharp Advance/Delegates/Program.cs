using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Delegates.SomeClass;
using System.Xml.Linq;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass x = new SomeClass();

            x.sender += Receiver;
            x.sender += Receiver1;
            x.sender += Receiver2;
            //x.sender -= Receiver;

            //x.sender = null; //not allowed in event

            Thread t = new Thread(new ThreadStart(x.HugeProcess));
            t.Start();
            //x.HugeProcess();
            Console.WriteLine("Main Thread");
            Console.ReadLine();

        }

        static void Receiver(int i)
        {
            Console.WriteLine("rec " + i);
        }

        static void Receiver1(int i)
        {
            Console.WriteLine("rec1 " + i);
        }

        static void Receiver2(int i)
        {
            Console.WriteLine("rec2 " + i);
        }

    }

    class SomeClass
    {
        public delegate void Sender(int i); //delegate declaration
        public event Sender sender = null;

        public void HugeProcess()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                sender(i);
            }
        }

        //Innocence Delegate is a Pointer to function
        //Thread Parallel , Async processing prequiste for delegates
        //You do your work  will do my --CallBack when done
        //From callback to Broadcasting -- Mulicast 
        //From Broadcasting to Publisher Subscriber - Events 
        // we can subscribe unscribe but not delete intance -Events(it is observer design pattern and pure publisher subscriber)
        //Event encapsulation over delegates.

        //Delegate is meant for callbacks
        //Delegates can be converted to Multicast
        //In Multicast delegate client can manipulate the Senders delgate objects
        //event IServiceProvider pure publisher subscriber

    }
}

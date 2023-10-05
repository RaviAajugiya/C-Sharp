using System;
namespace ConsoleApp
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                char a = 'A';
                for (int j = 0; j < i; j++)
                {
                    Console.Write(a + " ");
                    a++;
                }

                char b = 'A';
                for (int j = i; j >= 0; j--)
                {
                    //Console.Write("{0} ",Convert.ToChar(b + j));
                    Console.Write(Convert.ToChar(b + j) + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
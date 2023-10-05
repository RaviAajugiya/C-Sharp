using System;

class Program1
{
    private static void Main(string[] args)
    {
        //string a = "12";
        //Console.WriteLine(Convert.ToInt32(a));

        //string name = $"Ravi {a}";
        //Console.WriteLine(name);


        //----------Function ref---------

        //int x = 5;
        //int y = 10;

        //Program1 p = new Program1();
        //Console.WriteLine($"before {x}");

        //p.Sum(ref x, ref y);
        //Console.WriteLine($"after {x}");
        //Console.WriteLine(y);


        //------------out parameter------------
        // not req initialization before passing same as ref

        //int a ;
        //Program1 program = new Program1();
        //program.show(out a);
        //Console.WriteLine("after " + a);


        // ====================Arrays======================

        //int[] arr = new int[5];
        //int[] arr2 = new int[5] {1,2,3,4,5};
        //int[] arr3 = { 1, 2, 3, 4, 5 };

        //arr[0] = 10;
        //for (int i = 0; i < arr3.Length; i++)
        //{
        //    Console.WriteLine(arr3[i]);
        //}

        //int min = arr3[0];
        //foreach(int i in arr3)
        //{
        //    if (i < min)
        //    {
        //        min = i;
        //    }
        //}
        //Console.WriteLine("min" + min);

        //multidimention array

        int[,] mdarr = new int[5, 5];
        int[,] mdarr1 = new int[,] { { 1, 1, 1 }, { 2, 2, 2 } };

        Console.WriteLine("rank " + mdarr1.Rank);
        Console.WriteLine("rank " + mdarr1.IsFixedSize);
        Console.WriteLine("rank " + mdarr1.IsReadOnly);
        Console.WriteLine("rank " + mdarr1.Length);
        Console.WriteLine("rank " + mdarr1.LongLength);



        //jagged array

        //int[][] jgarr = new int[2][];
        //jgarr[0] = new int[5];
        //jgarr[1] = new int[] { 1, 2, 3, 4 };

        //for (int i = 0; i < jgarr.Length; i++)
        //{
        //    for (int j = 0; j < jgarr[i].Length; j++)
        //    {
        //        Console.Write(jgarr[i][j]);
        //    }
        //    Console.WriteLine();
        //}

        //int[][] jgarr1 = new int[3][]
        //{
        //    new int[] { 11, 21, 56, 78 },
        //    new int[] { 2, 5, 6, 7, 98, 5 },
        //    new int[] { 2, 5 }
        //};

        //for (int i = 0; i < jgarr1.Length; i++)
        //{
        //    for (int j = 0; j < jgarr1[i].Length; j++)
        //    {
        //        Console.Write(jgarr1[i][j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //===================Params=========================

        Program1 p1 = new Program1();
        p1.paramsEx(1, 2, 5, 8, 6, 45, 4, 746, 8764, 5646);
        p1.paramsEx1('s', true, 'd', 656, "dsadsad");

    }

    public void paramsEx(params int[] val)
    {
        for (int i = 0; i < val.Length; i++)
        {
            Console.Write(val[i] + " "); ;
        }
    }

    public void paramsEx1(params object[] val)
    {
        for (int i = 0; i < val.Length; i++)
        {
            Console.WriteLine(val[i] + " "); ;
        }
    }

    public void Sum(ref int a, ref int b)
    {
        a = 10;
        Console.WriteLine(a + b);
    }

    public void show(out int a)
    {
        int sq = 10;
        a = sq;
    }
}
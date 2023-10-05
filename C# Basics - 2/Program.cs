using Object_Class;
using System;
using System.Reflection.Emit;

class Program
{
    public static void Main(string[] args)
    {
        //Student student = new Student();
        //Student s1 = new Student(2, "aajugiya");
        //Student s2 = new Student();

        //student.setStudent(1, "Ravi");
        //student.getStudent();

        //s1.getStudent();
        //s2.getStudent();
        //Student student2 = new Student();

        //=================static field================
        //Account a1 = new Account(1, "Ravi");
        //a1.display();

        //Account a2 = new Account(2, "Ravi2");
        //Account.rateOfInterest = 5.5f;
        //a2.display();

        //Account a3 = new Account();

        //Console.WriteLine(Account.rateOfInterest);
        ////Count no of obj
        //Console.WriteLine(Account.objCount);


        //================static Class====================
        //Console.WriteLine(StaticClass.PI);
        //Console.WriteLine(StaticClass.cube(5));


        //================static constructor ===================
        //Bus bus1 = new Bus(71);

        //Bus bus2 = new Bus(72);
        //bus1.Drive();

        //// Wait for bus2 to warm up.
        //System.Threading.Thread.Sleep(25);

        //// Send bus2 on its way.
        //bus2.Drive();

        //// Keep the console window open in debug mode.
        //Console.WriteLine("Press any key to exit.");
        //Console.ReadKey();


        //==================struct================================
        Ractangle r1;
        r1.height = 100;
        r1.width = 100;

        Ractangle r2 = new Ractangle(5, 10);
        r2.areaOfRectangle();
        r1.areaOfRectangle();

        public enum level { high, medium, low }



}
}

public class Student
{
    public int Id;
    public string Name;

    public Student()
    {
        Console.WriteLine("Default Constructor");
    }

    ~Student()
    {
        Console.WriteLine("Destructure invoked");
    }

    public Student(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public void setStudent(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public void getStudent()
    {
        Console.WriteLine(this.Id + " " + this.Name);
    }
}
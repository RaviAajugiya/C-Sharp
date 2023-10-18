using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };

        ////IEnumerable<int> result = from numbers in num
        ////                          where numbers > 3
        ////                          select numbers;
        ////Console.WriteLine(result);

        //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        ////Query syntax
        //var qs = from obj in list
        //         where obj > 5
        //         select obj;
        //foreach (var item in qs)
        //{
        //    Console.WriteLine(item);
        //}

        ////Method syntax
        //var methodSyntax = list.Where(obj => obj > 5);
        //foreach (var item in methodSyntax)
        //{
        //    Console.WriteLine(item);
        //}

        ////mixed syntax
        //var mixed = (from obj in list
        //             where obj > 5
        //             select obj).Sum();

        //Console.WriteLine(mixed);


        ////---------------------LambdaExpression---------------------

        //List<String> strings = new List<String>();
        //strings.Add("a");
        //strings.Add("b");
        //strings.Add("c");
        //strings.Add("eeeed");
        //strings.Add("e");
        //strings.Add("f");

        //IEnumerable<string> result = strings.Select(x => x);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("Aggregate " + list.Aggregate((a, b) => a + b));

        List<Student> students = new List<Student>()
        {
            new Student() {name = "name1", age = 5, Subjects = new List<string>{"sub1", "sub2"} },
            new Student() {name = "name4", age = 5, Subjects = new List<string>{"sub1", "sub2"} },
            new Student() {name = "name3", age = 5, Subjects = new List<string>{"sub1", "sub2"} },
            new Student() {name = "name2", age = 5, Subjects = new List<string>{"sub1", "sub2"} },
            new Student() {name = "name4", age = 3, Subjects = new List<string>{"sub1", "sub2"} },
            new Student() {name = "name5", age = 3, Subjects = new List<string>{"sub1", "sub2"} }
        };

        var studentName = students.OrderByDescending(x => x.name).ThenByDescending(x => x.age).Reverse().ToList<Student>;


        IEnumerable<Student> Top3 = students.Take(3);
        IEnumerable<Student> takeWhile = students.TakeWhile(x => x.age == 5);

        var takeWhile1 = (from i in students
                          where i.age == 3
                          select i);

        var lookup = students.ToLookup(x => x.age);


        foreach (var KeyValuePair in lookup)
        {
            Console.WriteLine(KeyValuePair.Key);
        }

        List<Employee> objEmployee = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                new Employee(){ Name="Shubham Ratogi1", Department="IT", Country="Canada"}
            };
        //objEmployee.ToLookup() method is used to print the value of the data in the pair/collection of items.  
        //var Emp = objEmployee.ToLookup(x => x.Department);
        //console.writeline("grouping employees by department");
        //console.writeline("---------------------------------");
        //foreach (var keyvalurpair in emp)
        //{
        //    console.writeline(keyvalurpair.key);
        //    //lookup employees by department
        //    foreach (var item in emp[keyvalurpair.key])
        //    {
        //        console.writeline("\t" + item.name + "\t" + item.department + "\t" + item.country);
        //    }
        //}


        ArrayList al = new ArrayList();
        al.Add("name1");
        al.Add("name2");
        al.Add(5);


        IEnumerable<string> result = al.Cast<string>();
        IEnumerable<string> result1 = al.OfType<string>();

        List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(li.GetType());
        var result2 = li.AsEnumerable();

        var result3 = objEmployee.ToDictionary(x => x.Country, x => x.Name);
        var result4 = objEmployee.Single(x => x.Name == "Shubham Ratogi");
        Console.WriteLine(result4.Country);

        //foreach (var item in result3)
        //{
        //    Console.WriteLine(item.Name + " " + item.Country);
        //}


        int[] amounts = { 5000, 2500, 9000, 8000,
                    6500, 4000, 1500, 5500 };

        IEnumerable<int> query =
            amounts.SkipWhile(amount => amount > 3000);

        foreach (int amount in query)
        {
            Console.WriteLine(amount);
        }
    }
}
class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Country { get; set; }
}
class Student
{
    public string name;
    public int age;
    public List<string> Subjects;
}
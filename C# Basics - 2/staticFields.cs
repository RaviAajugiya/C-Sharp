using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    public class Account
    {
        public int accountNo;
        public string name;
        public static float rateOfInterest = 8.8f;
        public static int objCount = 0;

        public Account()
        {
            objCount++;
        }

        public Account(int accountNo, string name)
        {
            this.accountNo = accountNo;
            this.name = name;
            objCount++;

        }

        public void display()
        {
            Console.WriteLine(accountNo + " " + name + " " + rateOfInterest);
        }
    }
}

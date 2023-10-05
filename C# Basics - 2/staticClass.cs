using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    public static class StaticClass
    {
        //Can not not be instantiated,  can only have static members
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
}

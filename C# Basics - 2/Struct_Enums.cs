using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    public struct Ractangle
    {
        public int width, height;
        public Ractangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }

    public class Enums
    {

    }

}



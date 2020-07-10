using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram
{
    class Rectangle:ShapeInterface 
    {
        int length, breadth;

        public Rectangle(int len, int bre)
        {
            length = len;
            breadth = bre;
        }
            public Double ShapeArea()
            {
                return (length * breadth);

            }


        

    }
}

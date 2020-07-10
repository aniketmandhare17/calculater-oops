using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram
{
    class Triangle:ShapeInterface 
    {
        int  breadth,hight;

        public Triangle (int bre, int hig)
        {
            breadth = bre;
            hight = hig;

        }
        public Double ShapeArea()
        {
            return (1/2*breadth * hight);

        }
    }
}

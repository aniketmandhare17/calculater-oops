using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram
{
    class Circle:ShapeInterface 
    {
        int radius;
        public Circle(int radi)
        {
            radius = radi;
        }

        public double ShapeArea()
        {
            Double answer;
            answer = 3.14 * radius * radius;
            return answer;

        }


    }
}

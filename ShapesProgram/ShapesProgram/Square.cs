using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram
{
    class Square:ShapeInterface 
    {
        int side;
        public Square(int sq)
        {
            side = sq;
        }

        public Double ShapeArea()
        {
            return (side * side);
        }
    }
}

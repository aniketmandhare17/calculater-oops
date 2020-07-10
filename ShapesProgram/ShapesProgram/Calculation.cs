using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram
{
    class Calculation
    {
        public Double  cal(int[]arr,int opration )
        {
            ShapeInterface  area = null;
            Double result = 0;
            area = Calculation.shapeobj(arr, opration);
            result = area.ShapeArea();
            return result;
        }
        private static ShapeInterface  shapeobj(int[] arr,int operation)
        {
            ShapeInterface  s = null;
            if(operation ==1)
            {
                s = new Circle(arr[0]);

            }
            else if (operation == 2)
            {
                s = new Triangle (arr[2],arr[4]);

            }
            else if (operation == 3)
            {
                s = new Rectangle (arr[1], arr[5]);

            }
            if (operation == 4)
            {
                s = new Square (arr[3]);

            }
            return s;
        }
    }
}

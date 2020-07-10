using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = 0;
            Double result;
            int radius, lenght, hight, side, breadth, width;

            Console.WriteLine("Enter The Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Lenght:");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Hight:");
            hight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Side:");
            side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Width:");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select The Shape:");
            Console.WriteLine(" 1 Circle,2 Triangle , 3 Rectangle, 4 Square");
            operation = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[] { radius, lenght, hight, side, breadth, width };
            Calculation calculation = new Calculation();
            result = calculation.cal(Array, operation);
            Console.WriteLine("The Area is :" + result);
            Console.ReadLine();

        }
    }
}


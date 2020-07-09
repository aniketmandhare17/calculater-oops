using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Program
    {
     
       public static void Main(string[] args)
        {
            int Num1, Num2,z;
            int p1;
            Console.WriteLine("This is the Calculator Operation Program:");

            Console.WriteLine("Select yours Operation:");
            Console.WriteLine("Enter Yours Num1:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Yours Num2:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0 Addition , 1 Substraction , 3 Multiplication, 4 Division");
            z = Convert.ToInt32(Console.ReadLine());
            calculator C = new calculator();
           p1= C.cal1(Num1 ,Num2,z );
            Console.WriteLine("Answer Is the :" + p1);
            Console.ReadLine();
        }
        
    }
}

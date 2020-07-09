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
            int num1, num2, operation;
            int result;
            Console.WriteLine("This is the Calculator Operation Program:");
            Console.WriteLine("Enter Yours Num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Yours Num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select yours Operation:");
            Console.WriteLine("0 Addition , 1 Substraction , 3 Multiplication, 4 Division");
            operation = Convert.ToInt32(Console.ReadLine());
            Calculator calculator  = new Calculator();
            result = calculator.Calculation(num1, num2, operation);

            
            Console.WriteLine("Answer Is the :" + result);
            Console.ReadLine();
        }

    }
}


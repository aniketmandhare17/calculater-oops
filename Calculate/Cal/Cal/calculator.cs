using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Calculator
    {
        public int Calculation(int num1, int num2, int operation)
        {

            ICalculator calculator = null;
            int result = 0;
            calculator = GetcalculatorInstnce(operation);
            result = calculator.Calculation(num1, num2);
            return result;

        }

        private static ICalculator GetcalculatorInstnce(int operation)
        {
            ICalculator calculator = null;
            if (operation == 0)
            {
                calculator = new Addition();

            }
            else if (operation == 1)
            {
                calculator = new Sub();

            }
            else if (operation == 2)
            {
                calculator = new Multiplication();

            }
            else if (operation == 3)
            {
                calculator = new Division();


            }

            return calculator;
        }
    }
}

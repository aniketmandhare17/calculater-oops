using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Addition: ICalculator
    {
     

        public int Calculation(int num1, int num2)
        {

            int answer;
            answer = num1 + num2;
            return answer;
        }
    }
}

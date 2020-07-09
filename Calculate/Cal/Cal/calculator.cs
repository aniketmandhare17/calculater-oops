using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class calculator
    {
     public int cal1(int a,int b,int c)
        {
            int p = a;
            int q = b;
            int r = c;
        int result=0;

          
            if (r == 0)
            {
                Addition A = new Addition();
                result = A.Add(p, q);
                
                

            }
            else if (r == 1)
            {
                Sub S = new Sub();
                result = S.Sub1(p, q);
            }
            else if (r == 2)
            {
                Multiplication M = new Multiplication();
                result = M.Mul(p, q);
            }
            else if (r == 3)
            {
                Division D = new Division();

                result = D.Div(p, q);
            }
            return  result;

        }
        
       
    }
}

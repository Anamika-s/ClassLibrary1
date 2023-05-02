using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
     
    internal static class NumericFunctionsExtended
    {
        //static NumericFunctions numeric;
        public static string AllEven(this NumericFunctions numericFunctions,
             int start, int end)
        {
              StringBuilder stringBuilder= new StringBuilder();
            for(int i=start; i<end; i++)
            {
                if (i % 2 == 0)
                    stringBuilder.Append(i+"\n");
            }
            return stringBuilder.ToString();
        }
        public static string PrintTable(this NumericFunctions numericFunctions, int num)
        {
            StringBuilder stringBuilder= new StringBuilder();
            for(int i=1;i<=10;i++)
            {
                stringBuilder.Append(num + " * " + i + " = " + num * i + "\n");
            }
            return stringBuilder.ToString();
        }
        
    }
}

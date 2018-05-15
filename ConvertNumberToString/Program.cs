using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToString
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
     public class GetWord
    {
         private  String[] SingleDigit = new String[]{"ноль", "один", "два", "три", "четыре",
                "пять", "шесть", "семь", "восемь", "девять"};
 
    
         public string GetOneDigitNumber(int digt)
        {

            return SingleDigit[digt];
        }

    }
}

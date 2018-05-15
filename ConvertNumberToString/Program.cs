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
    public static class GetWord
    {
        static private  String[] SingleDigit = new String[]{"ноль", "один", "два", "три", "четыре",
                "пять", "шесть", "семь", "восемь", "девять"};
    public static int GetFive()
        {
            return 5;
        }
      
    
        public static string GetOneDigitNumber(int digt)
        {

            return SingleDigit[digt];
        }

    }
}

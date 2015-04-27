using System;
using System.Text;

namespace CalculatorKata
{
    public class Calculator
    {
        private int sum = 0;

        public int Add(String numbers)
        {
            sum = 0;

            while (numbers.Contains(","))
            {
                numbers = AddNextNumberToSum(numbers);
            }
            sum += SumOfZeroOrOneNumbers(numbers);

            return sum;
        }



        private string AddNextNumberToSum(string s)
        {
            int pos = 0;


            while (s.Substring(pos, 1) != ",")
            {
                pos++;
            }
            sum += Convert.ToInt16(s.Substring(0, pos));
            return s.Substring(pos + 1);
        }

        private int SumOfZeroOrOneNumbers(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            return Convert.ToInt16(s);
        }


    }
}
    
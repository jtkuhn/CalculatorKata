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
            AddZeroOrOneNumberToSum(numbers);

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

        private void AddZeroOrOneNumberToSum(string s)
        {
            if (s.Length != 0)
            {
                sum += Convert.ToInt16(s);
            }
        }


    }
}
    
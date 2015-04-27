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

            if (numbers.Length == 1 || numbers.Length == 0)
            {
                return SumOfZeroOrOneNumbers(numbers);
            }

            while (numbers.Contains(","))
            {
                numbers = GetNextNumber(numbers);
            }
            sum += Convert.ToInt16(numbers);

            return sum;
        }



        private string GetNextNumber(string s)
        {
            StringBuilder sb = new StringBuilder();
            int pos = 0;


            while (s.Substring(pos, 1) != ",")
            {
                sb.Append(s.Substring(pos, 1));
                pos++;
            }
            sum += Convert.ToInt16(sb.ToString());
            sb.Clear();
            return s.Substring(pos + 1);
        }

        private int SumOfZeroOrOneNumbers(string s)
        {
            if (s.Length == 1)
            {
                return Convert.ToInt16(s);
            }
            else return 0;
        }


    }
}
    
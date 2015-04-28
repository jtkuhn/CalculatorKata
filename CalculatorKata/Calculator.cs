using System;
using System.IO;
using System.Text;

namespace CalculatorKata
{
    public class Calculator
    {
        private int _sum = 0;

        string _delimiter = "\n";

        public int Add(String numbers)
        {
            CheckForNegatives(numbers);
            _sum = 0;
            numbers = SetNewDelimiter(numbers);

            while (numbers.Contains(",") || numbers.Contains("\n") || numbers.Contains(_delimiter))
            {
                numbers = AddNextNumberToSum(numbers);
            }
            AddZeroOrOneNumberToSum(numbers);

            return _sum;
        }

        private String SetNewDelimiter(string s)
        {
            if (s.StartsWith("//"))
            {
                int pos = 2;
                while (s.Substring(pos, 1) != "\n")
                {
                    pos++;
                }
                _delimiter = s.Substring(2, pos - 2);
                return s.Substring(pos + 1);
            }
            else return s;
        }

        private void CheckForNegatives(string s)
        {
            if (s.Contains("-"))
            {
                throw new Exception("Negatives not allowed");
            }
        }

        private string AddNextNumberToSum(string s)
        {
            int pos = 0;

            while (s.Substring(pos, 1) != "," && s.Substring(pos, 1) != "\n" && s.Substring(pos, 1) != _delimiter)
            {
                pos++;
            }
            _sum += AssertBelow1001(Convert.ToInt16(s.Substring(0, pos)));
            return s.Substring(pos + 1);
            
        }

        private int AssertBelow1001(int x)
        {
            if (x < 1001)
                return x;
            else return 0;

        }

        private void AddZeroOrOneNumberToSum(string s)
        {
            if (s.Length != 0)
            {
                _sum += Convert.ToInt16(s);
            }
        }


    }
}
    
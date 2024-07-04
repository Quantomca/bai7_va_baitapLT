using System;

namespace OOPExamples
{
    public class array_double_1d
    {
        private double[] _numbers;

        public double FindMin()
        {
            double min = _numbers[0];

            for (int i = 1; i < _numbers.Length; i++)
            {
                if (_numbers[i] < min)
                {
                    min = _numbers[i];
                }
            }

            return min;
        }

        public double FindMax()
        {
            double max = _numbers[0];

            for (int i = 1; i < _numbers.Length; i++)
            {
                if (_numbers[i] > max)
                {
                    max = _numbers[i];
                }
            }

            return max;
        }

        public void setNumbers(double[] numbers)
        {
            _numbers = numbers;
        }
    }
}

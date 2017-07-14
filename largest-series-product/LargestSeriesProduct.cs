using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span == 0)
            return 1;

        if (span < 0 || digits.Length < span)
            throw new ArgumentException();

        long largest = 0;
        for (int i = 0; i <= digits.Length - span; ++i)
        {
            var numbers = digits.Substring(i, span);

            long product = 1;
            foreach (var num in numbers)
            {
                if (!char.IsNumber(num))
                    throw new ArgumentException();

                product *= num - '0';
            }

            if (product > largest)
                largest = product;
        }

        return largest;
    }
}
using System;

namespace ExceptionHandling2
{
    public static class Extensions
    {
        public static int CustomIntParse(this string self)
        {
            if (string.IsNullOrEmpty(self))
            {
                throw new ArgumentNullException();
            }
            const string Digits = "0123456789";

            var result = 0;

            foreach (char item in self)
            {
                int searchResult = Digits.IndexOf(item);
                if (searchResult == -1)
                {
                    throw new FormatException();
                }

                result = result * 10 + searchResult;
            }

            return result;
        }
    }
}

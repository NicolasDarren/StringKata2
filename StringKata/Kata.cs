using System;

namespace StringKata
{
    public class Kata
    {
        public int Add(string input)
        {
            return string.IsNullOrEmpty(input) ? 0 : 1;
        }
    }
}

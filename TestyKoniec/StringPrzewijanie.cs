using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKoniec
{
    public class StringPrzewijanie
    {
        public string CharNum(int num, string input)
        {
            string resoult ="";
            if (num<0||string.IsNullOrEmpty(input))
            {
                return resoult;
            }
            else if (num<=input.Length)
            {
                resoult = input[num].ToString();
            }
            else if (num>input.Length)
            {
                resoult = input[-(input.Length - num)].ToString();
            }
            return resoult;
        }
    }
}

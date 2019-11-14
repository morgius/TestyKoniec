using System;

namespace TestyKoniec
{
    class Program
    {
        static void Main(string[] args)
        {
            StringPrzewijanie sp = new StringPrzewijanie();
            Console.WriteLine(sp.CharNum(9,"hello"));
        }
    }
}

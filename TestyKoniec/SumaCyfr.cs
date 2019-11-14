using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKoniec
{
    public class SumaCyfr
    {
        public int Suma(string input)
        {

            int resoult, reszta,suma =0;
            bool czyInt = int.TryParse(input, out resoult);
            if (!czyInt)
            {
                suma = 0;
            }
            else
            {
                while (resoult!=0)
                {
                    reszta = resoult % 10;
                    suma += reszta;
                    resoult = resoult / 10;
                }
            }
            return suma; 
        }
    }
}

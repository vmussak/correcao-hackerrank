using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Correcao
{
    public class MenorString
    {
        static BigInteger GetCharValue(char theChar) //D
        {
            if (theChar == 'A') return 1;

            var alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var charIndex = alfabeto.IndexOf(theChar); //3
            var multiplicador = charIndex + 1; //4

            var letraAnterior = alfabeto[charIndex - 1]; //C
            var letraAnteriorValue = GetCharValue(letraAnterior);

            BigInteger theValue = multiplicador * letraAnteriorValue + letraAnteriorValue;

            return theValue;
        }

        public static string GetShortestString(long weight) //25
        {
            BigInteger currentWeight = weight;
            var stringParaRetornar = "";

            var alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Reverse();

            foreach(char letra in alfabeto)
            {
                var charValue = GetCharValue(letra);

                while(charValue <= currentWeight)
                {
                    stringParaRetornar += letra;
                    currentWeight -= charValue;
                }

                if (currentWeight == 0) break;
            }

            return new string(stringParaRetornar.Reverse().ToArray());
        }


    }
}

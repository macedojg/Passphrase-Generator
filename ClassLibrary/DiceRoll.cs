using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary
{
    public class DiceRoll
    //copiado de https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rngcryptoserviceprovider?view=net-5.0
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public static byte D6()
        {
            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[1];
            do
            {
                // Fill the array with a random value.
                //É assim p
                rngCsp.GetBytes(randomNumber);
            }
            // 252 is 42*6, which is the maximum number of D6 sets on a byte struct (0-255), 
            // multiplied by number of sides since we will mod it by 6 later.
            while (!(randomNumber[0] < 252));
            // Return the random number mod the number
            // of sides.  The possible values are zero-
            // based, so we add one.
            return (byte)((randomNumber[0] % 6) + 1);
        }
    }
}

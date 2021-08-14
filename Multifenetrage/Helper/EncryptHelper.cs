using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifenetrage.Helper
{
    public class EncryptHelper
    {
        /*
         * cryptage en base 64

         * Base64Encode => text clair -> base 64
         * Bse64Decode => crypté => en text clair
        */


        public static string Base64Encode(string textClair)
        {
            // Convertir en byte
            var textClairByte = System.Text.Encoding.UTF8.GetBytes(textClair);
            return System.Convert.ToBase64String(textClairByte);
        }
        // Le text crypté en string
        public static string Base64Decode(string codeEnBase64)
        {
            var textByte = System.Convert.FromBase64String(codeEnBase64);

            return System.Text.Encoding.UTF8.GetString(textByte);

        }

    }
}

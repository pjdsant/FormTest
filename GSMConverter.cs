using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTest
{
    // Data/info taken from http://en.wikipedia.org/wiki/GSM_03.38
    public static class GSMConverter
    {

        public static string Encode7bit(string s)
        {
            string empty = string.Empty;
            for (int index = s.Length - 1; index >= 0; --index)
                empty += Convert.ToString((byte)s[index], 2).PadLeft(8, '0').Substring(1);
            string str1 = empty.PadLeft((int)Math.Ceiling((Decimal)empty.Length / new Decimal(8)) * 8, '0');
            List<byte> byteList = new List<byte>();
            while (str1 != string.Empty)
            {
                string str2 = str1.Substring(0, str1.Length > 7 ? 8 : str1.Length).PadRight(8, '0');
                str1 = str1.Length > 7 ? str1.Substring(8) : string.Empty;
                byteList.Add(Convert.ToByte(str2, 2));
            }
            byteList.Reverse();
            var messageBytes = byteList.ToArray();
            var encodedData = "";
            foreach (byte b in messageBytes)
            {
                encodedData += Convert.ToString(b, 16).PadLeft(2, '0');
            }
            return encodedData.ToUpper();
        }

        // The index of the character in the string represents the index
        // of the character in the respective character set

        // Basic Character Set
        private const string BASIC_SET =
                "@£$¥èéùìòÇ\nØø\rÅåΔ_ΦΓΛΩΠΨΣΘΞ\x1bÆæßÉ !\"#¤%&'()*+,-./0123456789:;<=>?" +
                "¡ABCDEFGHIJKLMNOPQRSTUVWXYZÄÖÑÜ§¿abcdefghijklmnopqrstuvwxyzäöñüà";

        // Basic Character Set Extension 
        private const string EXTENSION_SET =
                "````````````````````^```````````````````{}`````\\````````````[~]`" +
                "|````````````````````````````````````€``````````````````````````";

        // If the character is in the extension set, it must be preceded
        // with an 'ESC' character whose index is '27' in the Basic Character Set
        private const int ESC_INDEX = 27;

        public static string StringToGSMHexString(string text, bool delimitWithDash = true)
        {
            // Replace \r\n with \r to reduce character count
            text = text.Replace(Environment.NewLine, "\r");

            // Use this list to store the index of the character in 
            // the basic/extension character sets
            var indicies = new List<int>();

            foreach (var c in text)
            {
                int index = BASIC_SET.IndexOf(c);
                if (index != -1)
                {
                    indicies.Add(index);
                    continue;
                }

                index = EXTENSION_SET.IndexOf(c);
                if (index != -1)
                {
                    // Add the 'ESC' character index before adding 
                    // the extension character index
                    indicies.Add(ESC_INDEX);
                    indicies.Add(index);
                    continue;
                }
            }

            // Convert indicies to 2-digit hex
            var hex = indicies.Select(i => i.ToString("X2")).ToArray();

            string delimiter = delimitWithDash ? "-" : "";

            // Delimit output
            string delimited = string.Join(delimiter, hex);
            return delimited;
        }
    }
}

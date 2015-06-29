using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndDecode
{
    class EncodeAndDecode
    {
        static void Main()
        {
            string inputStr = "Write a program that encodes and decodes a string.";
            string key = "123X";
            Console.WriteLine("Input :{0}", inputStr);
            string encodedStr = EncDec(inputStr, key);
            Console.WriteLine("Encoded :{0}", encodedStr);
            string decodedStr = EncDec(encodedStr, key);
            Console.WriteLine("Decoded :{0}", decodedStr);
        }
        public static string EncDec(string inputStr, string secretKey)
        {
            char[] strAsArr = inputStr.ToCharArray();
            for (int i = 0; i < strAsArr.Length; i++)
            {
                strAsArr[i] = (char)(strAsArr[i] ^ secretKey[i % secretKey.Length ]);
            }
            return new String(strAsArr);
        }
    }
}

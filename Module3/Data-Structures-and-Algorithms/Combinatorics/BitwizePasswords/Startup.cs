namespace BitwizePasswords
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Startup
    {
        public static BigInteger result = 0;
        public static int PasswordLength;
        public static long template;

        public static void Main()
        {
            var input = Console.ReadLine();
            PasswordLength = input.Length;
            long mask = GenerateMask(input);
            //template = GenerateTemplate(input);

            // GeneratePasswords(mask, 0);

            //var end = 1 << PasswordLength;
            //for (int i = 0; i < end; i++)
            //{
            //    if ((i & mask) == template)
            //    {
            //        result++;
            //    }

            //}
            //Console.WriteLine(result);

            var numberOfAsteriks = input.ToCharArray().Where(c => c == '*').ToArray().Length;
            BigInteger fastResult = 1;

            for (int i = 0; i < numberOfAsteriks; i++)
            {
                fastResult *= 2;
            }
            
            Console.WriteLine(fastResult);
        }

        private static void GeneratePasswords(long mask, int i)
        {
            do
            {
                if (i >= PasswordLength)
                {
                    break;
                }

                if ((mask & (1 << i)) == 0)
                {
                    GeneratePasswords(mask ^ (1 << i), i + 1);
                    GeneratePasswords(mask ^ (1 << i), i + 1);
                    break;
                }
                else
                {
                    i++;
                }
            } while (true);
            
            if (i >= PasswordLength)
            {
                result++;
            }
        }

        private static long GenerateTemplate(string input)
        {
            long template = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                {
                    template = template ^ (1 << i);
                }
            }

            return template;
        }

        private static long GenerateMask(string input)
        {
            long mask = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1' || input[i] == '0')
                {
                    mask = mask ^ (1 << i);
                }
            }

            return mask;
        }
    }
}

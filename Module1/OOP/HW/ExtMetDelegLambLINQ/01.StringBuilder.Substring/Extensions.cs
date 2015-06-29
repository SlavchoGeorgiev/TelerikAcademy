namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int lenght)
        {
            string result = sb.ToString().Substring(index, lenght);
            return new StringBuilder(result);
        }
    }
}

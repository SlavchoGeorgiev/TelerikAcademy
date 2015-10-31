namespace Helpers
{
    using System.Collections.Generic;
    using System.IO;

    public class ColectionGenerator
    {
        public static List<int> GenerateList(TextReader textReder)
        {
            var list = new List<int>();
            string currentLine;
            int currentValue;
            do
            {
                currentLine = textReder.ReadLine();
                if (int.TryParse(currentLine, out currentValue))
                {
                    list.Add(currentValue);
                }
            }
            while (!string.IsNullOrEmpty(currentLine));

            return list;
        }
    }
}

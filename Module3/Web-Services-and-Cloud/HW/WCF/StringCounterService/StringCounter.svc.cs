namespace StringCounterService
{
    public class StringCounter : IStringCounter
    {
        public int GetCount(string search, string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length - search.Length + 1; i++)
            {
                bool isMatch = true;

                for (int j = 0; j < search.Length; j++)
                {
                    if (text[i + j] != search[j])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

namespace Project_05
{

    internal class UppercaseResolver : AbstractResolver
    {
        public UppercaseResolver()
        {
        }

        private string? Longest(string[] words)
        {
            string? longestWord = null;
            int longestWordLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length > longestWordLength)
                {
                    longestWordLength = currentWord.Length;
                    longestWord = currentWord;
                }
            }

            return longestWord;
        }

        public override string? Execute(string content)
        {
            string[] words = content.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            string? longestWord = Longest(words);          


            return longestWord;
        }
    }
}
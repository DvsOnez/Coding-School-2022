namespace Project_05
{
    public class ReverseResolver : AbstractResolver
    {

        private static string ReverseString(string str)
        {
            string reversedString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
                reversedString += str[i];

            return reversedString;
        }

        public override string Execute(string content)
        {

            return ReverseString(content);
        }
    }
}
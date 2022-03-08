namespace Project_05
{
    public class ConvertResolver : AbstractResolver {
        public ConvertResolver()
        { }
        

        public override string? Execute(string content)
        {
        
        int result;
            if (!int.TryParse(content, out result))
            {

                return null;
            }

            return Convert.ToString(result, 2);
        }
    }
}
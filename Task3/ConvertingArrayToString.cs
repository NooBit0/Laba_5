using System.Text;

namespace Laba5
{
    public static class ConvertingArrayToString
    {
        public static string Get(string[] text)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }
    }
}

using System.Text;

    public static class StringExtensions
    {
        public static int ToInt(this string str)
        {
            int converted = 0;
            int.TryParse(str, out converted);
            return converted;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNumber(this string str)
        {
            foreach (char c in str)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static string BreakCharsToLines(this string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in input)
            {
                sb.AppendLine(c.ToString());
            }
            return sb.ToString().Trim('\n');
        }

        public static int FewCharsToString(this string input, char chr)
        {
            int i = 0;
            foreach (char c in input)
            {
                if (c == chr)
                    i++;
            }
            return i;
        }
    }

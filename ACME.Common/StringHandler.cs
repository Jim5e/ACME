namespace ACME.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert before each upperchar in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
       public static string InsertSpaces (this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }

                    if (!char.IsWhiteSpace(letter))
                    {
                        result += letter;
                    }
                }

            }
            result = result.Trim();
            return result;
        }
    }
}

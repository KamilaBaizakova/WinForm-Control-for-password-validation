using System.Linq;

namespace WindowsFormsControlLibrary1
{
    static class StringUtility
    {
        public static bool HasSpecialChar(string input, string setOfSpecialChars)
        {
            foreach (var item in setOfSpecialChars)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
    }
}

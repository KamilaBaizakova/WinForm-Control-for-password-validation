using System;
using System.Linq;

namespace WindowsFormsControlLibrary1
{
    class Password
    {
        private string passwordText;
        public string PasswordText
        {
            get => passwordText;
            set => passwordText = value;
        }
        public int MinNumberOfCharacters { get; internal set; }
        public string SetOfSpecialOfCharacters { get; internal set; }

        internal bool IsStrong()
        {
            return (StringUtility.HasSpecialChar(passwordText, SetOfSpecialOfCharacters) && (passwordText.Length >= MinNumberOfCharacters) && passwordText.Any(char.IsUpper));
        }

        internal bool IsValid()
        {
            return ((StringUtility.HasSpecialChar(passwordText, SetOfSpecialOfCharacters) && passwordText.Any(char.IsUpper))) || (StringUtility.HasSpecialChar(passwordText, SetOfSpecialOfCharacters) && (passwordText.Length >= MinNumberOfCharacters)) || ((passwordText.Length >= MinNumberOfCharacters) && passwordText.Any(char.IsUpper));
        }

        internal bool IsOneRequirementSatisfied()
        {
            return (passwordText.Length >= MinNumberOfCharacters) || passwordText.Any(char.IsUpper) || StringUtility.HasSpecialChar(passwordText, SetOfSpecialOfCharacters);
        }
    }
}

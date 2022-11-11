using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        private Password password;
        private int numberOfCharacters = 8;

        [Description("Enter minimum number of characters in the textbox"), Category("Data")]
        public int NumberOfCharacters
        {
            get => numberOfCharacters;
            set
            {
                numberOfCharacters = value;
                password.MinNumberOfCharacters = value;
            }
        }
        private string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

        [Description("Enter set of special characters required in the textbox"), Category("Data")]
        public string SpecialChar {
            get => specialChar;
            set  
                { 
                    specialChar = value;
                    password.SetOfSpecialOfCharacters = value;
                }
        }

        public event EventHandler PasswordStrong;
        public event EventHandler PasswordValid;
        public event EventHandler OneRequirementSatisfied;
        public event EventHandler NoRequirementSatisfied;

        public UserControl1()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void InitializeMyControl()
        {
            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            password = new Password() { PasswordText = textBox1.Text, MinNumberOfCharacters = numberOfCharacters, SetOfSpecialOfCharacters = SpecialChar };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password.PasswordText = textBox1.Text;
            if (password.IsStrong())
            {
                if (this.PasswordStrong != null)
                    this.PasswordStrong(this, new EventArgs());

            }
            else if (password.IsValid())
            {
                if (this.PasswordValid != null)
                    this.PasswordValid(this, new EventArgs());
            }
            else if (password.IsOneRequirementSatisfied())
            {
                if (this.OneRequirementSatisfied != null)
                    this.OneRequirementSatisfied(this, new EventArgs());
            }
            else
            {
                if (this.NoRequirementSatisfied != null)
                    this.NoRequirementSatisfied(this, new EventArgs());
            }
        }
        
    }
}

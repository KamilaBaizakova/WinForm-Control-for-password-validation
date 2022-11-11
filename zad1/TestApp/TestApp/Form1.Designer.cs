
namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.userControl11 = new WindowsFormsControlLibrary1.UserControl1();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(83, 199);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(536, 10);
            this.pBar1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(55, 130);
            this.userControl11.Name = "userControl11";
            this.userControl11.NumberOfCharacters = 8;
            this.userControl11.Size = new System.Drawing.Size(574, 63);
            this.userControl11.SpecialChar = "\\|!#$%&/()=?»«@£§€{}.-;\'<>_,";
            this.userControl11.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter password. Password must contain at least one capital letter and at l" +
    "east one special character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.pBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pBar1;
        private WindowsFormsControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.Label label2;
    }
}


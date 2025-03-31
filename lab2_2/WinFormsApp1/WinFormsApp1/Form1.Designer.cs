namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sstring = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // sstring
            // 
            sstring.Location = new Point(14, 36);
            sstring.Margin = new Padding(3, 4, 3, 4);
            sstring.Name = "sstring";
            sstring.Size = new Size(467, 27);
            sstring.TabIndex = 0;
            sstring.TextChanged += sstring_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(129, 75);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(259, 76);
            button1.TabIndex = 1;
            button1.Text = "расчитать % букв в строке";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 169);
            Controls.Add(button1);
            Controls.Add(sstring);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sstring;
        private Button button1;
    }
}

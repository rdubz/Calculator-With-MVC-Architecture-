namespace Calculator
{
    partial class Calculator
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
            this.CalculatorTextBox = new System.Windows.Forms.RichTextBox();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.OpenParen = new System.Windows.Forms.Button();
            this.ClosingParen = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculatorTextBox
            // 
            this.CalculatorTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculatorTextBox.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CalculatorTextBox.Location = new System.Drawing.Point(71, 98);
            this.CalculatorTextBox.Name = "CalculatorTextBox";
            this.CalculatorTextBox.Size = new System.Drawing.Size(683, 96);
            this.CalculatorTextBox.TabIndex = 0;
            this.CalculatorTextBox.Text = "";
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(71, 242);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(125, 85);
            this.Nine.TabIndex = 1;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(254, 242);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(125, 85);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(440, 242);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(125, 85);
            this.Seven.TabIndex = 3;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(71, 367);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(125, 85);
            this.Six.TabIndex = 4;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(254, 367);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(125, 85);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(440, 367);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(125, 85);
            this.Four.TabIndex = 6;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(71, 514);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(125, 85);
            this.Three.TabIndex = 7;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(254, 514);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(125, 85);
            this.Two.TabIndex = 8;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(440, 514);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(125, 85);
            this.One.TabIndex = 9;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(71, 656);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(125, 85);
            this.Zero.TabIndex = 10;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // OpenParen
            // 
            this.OpenParen.Location = new System.Drawing.Point(254, 656);
            this.OpenParen.Name = "OpenParen";
            this.OpenParen.Size = new System.Drawing.Size(125, 85);
            this.OpenParen.TabIndex = 11;
            this.OpenParen.Text = "(";
            this.OpenParen.UseVisualStyleBackColor = true;
            this.OpenParen.Click += new System.EventHandler(this.OpenParen_Click);
            // 
            // ClosingParen
            // 
            this.ClosingParen.Location = new System.Drawing.Point(440, 656);
            this.ClosingParen.Name = "ClosingParen";
            this.ClosingParen.Size = new System.Drawing.Size(125, 85);
            this.ClosingParen.TabIndex = 12;
            this.ClosingParen.Text = ")";
            this.ClosingParen.UseVisualStyleBackColor = true;
            this.ClosingParen.Click += new System.EventHandler(this.ClosingParen_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(627, 242);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(125, 85);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(627, 367);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(125, 85);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(627, 514);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(125, 85);
            this.Multiply.TabIndex = 15;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(629, 659);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(125, 85);
            this.Divide.TabIndex = 16;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(440, 790);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(310, 95);
            this.Enter.TabIndex = 17;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(71, 790);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(310, 95);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(863, 979);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.ClosingParen);
            this.Controls.Add(this.OpenParen);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.CalculatorTextBox);
            this.Name = "Calculator";
            this.Text = "Ryan\'s Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CalculatorTextBox;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button OpenParen;
        private System.Windows.Forms.Button ClosingParen;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Clear;
    }
}


namespace Calculator_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Plus = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Minus = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Multiply = new Button();
            Zero = new Button();
            FPoint = new Button();
            Divide = new Button();
            CE = new Button();
            C = new Button();
            Result = new Button();
            textBox1 = new TextBox();
            currentStatelable = new Label();
            SuspendLayout();
            // 
            // Seven
            // 
            Seven.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Seven.Location = new Point(12, 77);
            Seven.Name = "Seven";
            Seven.Size = new Size(60, 60);
            Seven.TabIndex = 0;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += button_Click;
            // 
            // Eight
            // 
            Eight.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Eight.Location = new Point(78, 77);
            Eight.Name = "Eight";
            Eight.Size = new Size(60, 60);
            Eight.TabIndex = 0;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += button_Click;
            // 
            // Nine
            // 
            Nine.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Nine.Location = new Point(144, 77);
            Nine.Name = "Nine";
            Nine.Size = new Size(60, 60);
            Nine.TabIndex = 0;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += button_Click;
            // 
            // Plus
            // 
            Plus.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Plus.Location = new Point(210, 77);
            Plus.Name = "Plus";
            Plus.Size = new Size(60, 60);
            Plus.TabIndex = 0;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Operator_Click;
            // 
            // Four
            // 
            Four.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Four.Location = new Point(12, 143);
            Four.Name = "Four";
            Four.Size = new Size(60, 60);
            Four.TabIndex = 0;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += button_Click;
            // 
            // Five
            // 
            Five.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Five.Location = new Point(78, 143);
            Five.Name = "Five";
            Five.Size = new Size(60, 60);
            Five.TabIndex = 0;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += button_Click;
            // 
            // Six
            // 
            Six.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Six.Location = new Point(144, 143);
            Six.Name = "Six";
            Six.Size = new Size(60, 60);
            Six.TabIndex = 0;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += button_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Minus.Location = new Point(210, 143);
            Minus.Name = "Minus";
            Minus.Size = new Size(60, 60);
            Minus.TabIndex = 0;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Operator_Click;
            // 
            // One
            // 
            One.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            One.Location = new Point(12, 209);
            One.Name = "One";
            One.Size = new Size(60, 60);
            One.TabIndex = 0;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += button_Click;
            // 
            // Two
            // 
            Two.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Two.Location = new Point(78, 209);
            Two.Name = "Two";
            Two.Size = new Size(60, 60);
            Two.TabIndex = 0;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += button_Click;
            // 
            // Three
            // 
            Three.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Three.Location = new Point(144, 209);
            Three.Name = "Three";
            Three.Size = new Size(60, 60);
            Three.TabIndex = 0;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += button_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Multiply.Location = new Point(210, 209);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(60, 60);
            Multiply.TabIndex = 0;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Operator_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Zero.Location = new Point(12, 275);
            Zero.Name = "Zero";
            Zero.Size = new Size(126, 60);
            Zero.TabIndex = 0;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += button_Click;
            // 
            // FPoint
            // 
            FPoint.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FPoint.Location = new Point(144, 275);
            FPoint.Name = "FPoint";
            FPoint.Size = new Size(60, 60);
            FPoint.TabIndex = 0;
            FPoint.Text = ".";
            FPoint.UseVisualStyleBackColor = true;
            FPoint.Click += button_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Divide.Location = new Point(210, 275);
            Divide.Name = "Divide";
            Divide.Size = new Size(60, 60);
            Divide.TabIndex = 0;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Operator_Click;
            // 
            // CE
            // 
            CE.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CE.Location = new Point(276, 77);
            CE.Name = "CE";
            CE.Size = new Size(60, 60);
            CE.TabIndex = 0;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = true;
            CE.Click += clear_Enitiy;
            // 
            // C
            // 
            C.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            C.Location = new Point(276, 143);
            C.Name = "C";
            C.RightToLeft = RightToLeft.Yes;
            C.Size = new Size(60, 60);
            C.TabIndex = 0;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += clear_All;
            // 
            // Result
            // 
            Result.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Result.Location = new Point(276, 209);
            Result.Name = "Result";
            Result.Size = new Size(60, 126);
            Result.TabIndex = 0;
            Result.Text = "=";
            Result.UseVisualStyleBackColor = true;
            Result.Click += result_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("CaskaydiaCove NFM", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // currentStatelable
            // 
            currentStatelable.AutoSize = true;
            currentStatelable.BackColor = Color.White;
            currentStatelable.FlatStyle = FlatStyle.Flat;
            currentStatelable.Font = new Font("CaskaydiaCove NFM", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            currentStatelable.ForeColor = SystemColors.ButtonShadow;
            currentStatelable.Location = new Point(12, 9);
            currentStatelable.Name = "currentStatelable";
            currentStatelable.Size = new Size(0, 20);
            currentStatelable.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 345);
            Controls.Add(currentStatelable);
            Controls.Add(textBox1);
            Controls.Add(Result);
            Controls.Add(C);
            Controls.Add(CE);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(FPoint);
            Controls.Add(Three);
            Controls.Add(Six);
            Controls.Add(Nine);
            Controls.Add(Two);
            Controls.Add(Five);
            Controls.Add(Eight);
            Controls.Add(Zero);
            Controls.Add(One);
            Controls.Add(Four);
            Controls.Add(Seven);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Plus;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Minus;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Multiply;
        private Button Zero;
        private Button FPoint;
        private Button Divide;
        private Button CE;
        private Button C;
        private Button Result;
        private TextBox textBox1;
        private Label currentStatelable;
    }
}
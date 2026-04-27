namespace Calculator
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
            txtOperand1 = new TextBox();
            txtOperand2 = new TextBox();
            cbxOperator = new ComboBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            lblOperand1 = new Label();
            lblOperator = new Label();
            lblOperand2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(189, 40);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(200, 39);
            txtOperand1.TabIndex = 0;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(189, 192);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(200, 39);
            txtOperand2.TabIndex = 1;
            // 
            // cbxOperator
            // 
            cbxOperator.FormattingEnabled = true;
            cbxOperator.Location = new Point(189, 114);
            cbxOperator.Name = "cbxOperator";
            cbxOperator.Size = new Size(82, 40);
            cbxOperator.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(189, 268);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(200, 39);
            txtResult.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(121, 360);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 68);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(121, 454);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblOperand1
            // 
            lblOperand1.AutoSize = true;
            lblOperand1.Location = new Point(45, 47);
            lblOperand1.Name = "lblOperand1";
            lblOperand1.Size = new Size(132, 32);
            lblOperand1.TabIndex = 6;
            lblOperand1.Text = "Operand 1:";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Location = new Point(68, 122);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(109, 32);
            lblOperator.TabIndex = 7;
            lblOperator.Text = "Operator";
            // 
            // lblOperand2
            // 
            lblOperand2.AutoSize = true;
            lblOperand2.Location = new Point(45, 199);
            lblOperand2.Name = "lblOperand2";
            lblOperand2.Size = new Size(132, 32);
            lblOperand2.TabIndex = 8;
            lblOperand2.Text = "Operand 2:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(94, 275);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(83, 32);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 534);
            Controls.Add(lblResult);
            Controls.Add(lblOperand2);
            Controls.Add(lblOperator);
            Controls.Add(lblOperand1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(cbxOperator);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperand1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperand1;
        private TextBox txtOperand2;
        private ComboBox cbxOperator;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnExit;
        private Label lblOperand1;
        private Label lblOperator;
        private Label lblOperand2;
        private Label lblResult;
    }
}

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = 0;
            decimal operand2 = 0;

            // Attempt to parse the input text into decimal numbers
            bool isValid1 = decimal.TryParse(txtOperand1.Text, out operand1);
            bool isValid2 = decimal.TryParse(txtOperand2.Text, out operand2);

            // Proceed only if both numbers were successfully parsed
            if (isValid1 && isValid2)
            {
                // Get the operator chosen by the user
                string selectedOperator = cbxOperator.SelectedItem.ToString();
                decimal result = 0;

                // Perform the appropriate mathematical operation
                switch (selectedOperator)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        // Ensure we don't attempt to divide by zero
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                        }
                        else
                        {
                            // Display an error and exit the method early on divide-by-zero
                            MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }
                // Display the calculated result
                txtResult.Text = result.ToString();
            }
            else
            {
                // Display an error if the user typed invalid inputs
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the current form/application
            this.Close();
        }
    }
}

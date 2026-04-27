// This code defines the main form of a simple calculator application.
// It includes event handlers for calculating results based on user
// input and for exiting the application. The code uses decimal data
// types for better precision and includes error handling for invalid
// inputs and division by zero.
// Authored by: Zac Kimball with help from copilot (for error handling and some comments).
// Date: 2026-04-27
// CPW 155 Basic Calculator Windows Forms Application
// Windows Forms Application created with .NET 10.0 and C#.

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the Calculate button click event
        // Caused by: User clicks the Calculate button after entering
        // operands and selecting an operator
        // Amended properties to accept return click event with keyboard
        // enter key
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // use decimal instead of double for better precision in
            // financial calculations
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
                // Used a combo box for operator selection to simplify
                // the UI and reduce input errors
                // Chosen by the user from a predefined list of operators
                // Can be added in code or through the designer properties
                // of the combo box
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
                        // users are evil and will try to break your app,
                        // so always validate inputs before performing
                        // operations
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                        }
                        else
                        {
                            // Display an error and exit the method early
                            // on divide-by-zero.
                            // This is a critical validation to prevent
                            // runtime exceptions and ensure the application
                            // remains stable
                            MessageBox.Show("Cannot divide by zero.", 
                                "Error", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }
                // Display the calculated result
                // Using ToString() to convert the result to a string for
                // display in the text box
                txtResult.Text = result.ToString();
            }
            else
            {
                // Display an error if the user typed invalid inputs
                // makes sure the user enters valid numbers before
                // performing calculations.
                MessageBox.Show("Please enter valid numbers.", 
                    "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Event handler for the Exit button click event
        // Changed cancel button properties to escape key click

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the current form/application

            this.Close();
        }
    }
}
 
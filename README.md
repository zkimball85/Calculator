# Calculator
Simple Calculator WinForms Application

## Overview
The Simple Calculator is a C# Windows Forms (WinForms) application designed to perform standard arithmetic operations. Developed as a practical project for the CPW program at Clover Park Technical College, this application demonstrates foundational concepts in event-driven programming, strict data validation, and explicit exception handling.

## Features
- Basic Arithmetic: Supports addition (+), subtraction (-), multiplication (*), and division (/).
- High Precision: All calculation results are automatically rounded to four decimal places for accuracy.
- Dynamic UI Updates: The result field clears automatically if the user modifies any of the operand or operator text boxes, ensuring stale or incorrect data is never displayed.
- Robust Error Handling: Prevents application crashes by catching invalid inputs and specific mathematical errors.

## Technical Specifications & Validation

To ensure reliable operation, the application enforces the following data validation rules before any mathematical processing occurs. If the data is invalid, an appropriate, user-friendly error message is displayed.

### Data Validation Methods
- IsPresent(): Verifies that text exists within the required input fields.
- IsDecimal(): Ensures the entered operands can be successfully parsed into valid numeric decimal values.
- IsOperator(): Validates that the entered operator strictly matches one of the four supported operation symbols (+, -, *, /).
- IsValidData(): A master validation wrapper that orchestrates the individual checks above.

### Input Constraints (Above and Beyond)
- Range Limits: Both operands must fall within the inclusive range of 0 to 1,000,000. 
- Divide-by-Zero Prevention: The application includes explicit logic to intercept and prevent division-by-zero exceptions when the / operator is used and the second operand evaluates to 0.

## Architecture

The core calculation logic is isolated from the UI event handlers to maintain a clean separation of concerns. It is encapsulated within the following private method:

private decimal Calculate(decimal operand1, string operator1, decimal operand2)

- operand1 (decimal): The validated numeric value of the first input.
- operator1 (string): The validated operator (+, -, *, or /).
- operand2 (decimal): The validated numeric value of the second input.
- Returns: The resulting calculated value as a decimal.

## Usage Instructions
1. Launch the application.
2. Enter a numeric value between 0 and 1,000,000 in the First Operand text box.
3. Enter a valid operator (+, -, *, or /) in the Operator text box.
4. Enter a numeric value between 0 and 1,000,000 in the Second Operand text box.
5. Click the Calculate button (or press the Enter key) to execute.
6. View the computed result, or address the error message prompt if the provided input violated validation rules.

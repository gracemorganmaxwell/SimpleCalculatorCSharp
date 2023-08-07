# Simple Calculator in C Sharp

Welcome, and thank you for viewing my Simple Calculator program in C#.

## Brief: 

A simple console-based calculator in C# that can perform basic arithmetic operations such as addition, subtraction, multiplication, and division. The program should take user input for two numbers and the desired operation and then display the result.

## Solution explained:

Namespace and Class: used the SimpleCalculator namespace to group the code and name the class Calculator to represent its purpose.

double Data Type: used the double data type to store the numbers instead of int to allow for decimal numbers and more accurate division.

double.TryParse: Similar to int.TryParse, this method converts a string into a double-precision floating-point number.

Switch Statement: This is used to evaluate the operation variable. Depending on its value, the execution of  the respective arithmetic operation occurs.

Division by Zero: It's essential to check if the user tries to divide by zero, as this is mathematically undefined and will throw an exception in the code when compiled. So displaying an error message in this case.

Result Output: using string interpolation to display the result to the user in a readable format in the Console.

### Note: 
The solution was created in Visual Studio IDE 2022 by Microsoft (Free) with C# V.7.0. 

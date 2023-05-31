# TryCatch_Capp

The TryCatch_Capp project is a console application that demonstrates the usage of try-catch blocks to handle exceptions. It includes a loop that divides a list of integers by a user-provided number and displays the results to the screen. The program handles potential errors gracefully using try-catch blocks.

# Project Description
The TryCatch_Capp project consists of a single file, Program.cs.

Program.cs

This file contains the Program class.

In the Main method of the Program class, a list of integers is created. The user is prompted to enter a number to divide each number in the list by.

A loop is used to iterate over each integer in the list, divide it by the user-provided number, and display the result to the console.

Initially, the code runs without any exception handling, allowing potential errors to occur if the user enters invalid input.

Then, the code is modified to include a try-catch block. Inside the try block, the division operation is performed, and the result is displayed. If an exception occurs during the division operation, the catch block is executed. The catch block displays an error message to the console.

After the try-catch block, a message is printed to indicate that the program has emerged from the try-catch block and continued with program execution.

# Instructions
Start the console application.

The program will prompt you to enter a number to divide each number in the list by.

Enter a non-zero number and observe the displayed results. The program will divide each number in the list by the entered number and display the result.

Rerun the program and this time enter zero as the number to divide by. Observe the error message displayed in the catch block.

Rerun the program once again and enter a string as the number to divide by. Observe the error message displayed in the catch block.

Modify the code to include the try-catch block.

Rerun the program and try various combinations of user input: valid numbers, zero, and a string. Ensure that the proper error messages are displayed on the screen and that the code after the try-catch block gets executed.

You can modify the list of integers or rerun the program with different inputs to explore different scenarios.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to exception handling in C#:

Handling exceptions using try-catch blocks

Catching specific exceptions and displaying custom error messages

Gracefully recovering from errors and continuing program execution

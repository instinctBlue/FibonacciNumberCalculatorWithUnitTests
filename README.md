# 🔢 Fibonacci Calculator in C#

This project provides a simple and efficient implementation of the **Fibonacci number calculator** using **C#** and includes **unit tests** written with **xUnit**.

## 📁 Project Structure

FibonacciApp/ # Main application
├── Program.cs # Console app entry point
└── FibonacciCalculator.cs # Fibonacci calculation logic

FibonacciApp.Tests/ # Unit test project
└── FibonacciTests.cs # xUnit test cases

---

## 🚀 Features

- Efficient **iterative Fibonacci algorithm**
- Clear separation of concerns (logic vs UI)
- Thorough **unit test coverage**
- Easy to run and extend

---

## 🛠️ Technologies Used

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- C#
- xUnit (for unit testing)

---

## 🧪 Running the Tests

1. Navigate to the solution directory in your terminal.
2. Run the following command:

```bash
dotnet test
You should see output indicating all tests have passed.

Running the App
To run the Fibonacci calculator console app:

bash
dotnet run --project FibonacciApp
You’ll be prompted to enter a non-negative integer. The program will output the corresponding Fibonacci number.

Example Usage
Enter a non-negative integer to calculate its Fibonacci number:
7
Fibonacci(7) = 13

Example Test Cases
Input n	Expected Output
0	0
1	1
5	5
10	55
15	610

Notes
Negative inputs throw an ArgumentException.

The algorithm is optimized for performance using iteration.

For very large numbers (e.g. n > 45), consider switching to long or BigInteger.

This project is open source and available under the MIT License.

Made by Linas – contributions welcome!

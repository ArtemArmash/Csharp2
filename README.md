# C# Array and Algorithm Exercises

This repository contains a collection of C# console applications designed to practice and demonstrate skills in array manipulation and basic algorithms. Each program solves a unique challenge, ranging from statistical calculations to classic cryptography.

## About The Projects

This collection includes three distinct console applications, each in its own file.

---

### 1. Multi-Array Statistics Calculator (`Program.cs`)

This program initializes two different arrays and calculates a comprehensive set of statistics for each.

*   **Purpose**:
    1.  Creates a one-dimensional array `A` of 5 `double` elements, filled with user input.
    2.  Creates a two-dimensional array `B` (3x4) of `double` elements, filled with random values.
    3.  Calculates and displays the following for both arrays:
        *   Maximum and minimum element.
        *   Sum of all elements.
        *   Product of all elements.
        *   Sum of even numbers (for array `A`).
        *   Sum of elements in odd-numbered columns (for array `B`).
*   **Concepts Demonstrated**: One-dimensional and two-dimensional arrays, user input processing, the `Random` class, `foreach` and nested `for` loops, and performing aggregate calculations.

**Usage Example:**
```
:
1.5
2
3
4.2
5
Array A:
1.5 2 3 4.2 5

Array B:
0.123...  0.456...  0.789...  0.111...
...

Max A: 5, Min A: 1.5, Sum A: 15.7, Product A: 126, Sum Even A: 2
Max B: ..., Min B: ..., Sum B: ..., Product B: ..., Sum Odd Columns B: ...
```

---

### 2. 2D Array Submatrix Summation (`Program1.cs`)

This application finds the sum of elements located in a rectangular region between the minimum and maximum values in a 2D array.

*   **Purpose**:
    1.  Creates and fills a 5x5 two-dimensional array with random integers between -100 and 100.
    2.  Finds the minimum and maximum elements and their positions (row and column).
    3.  Calculates the sum of all elements located *between* the minimum and maximum elements, forming a conceptual sub-rectangle.
*   **Concepts Demonstrated**: 2D arrays, random number generation, nested loops for traversal, finding min/max values and their indices, using `Math.Min` and `Math.Max` to define dynamic loop boundaries.

**Usage Example:**
```
2X2 Array:
10      -5      ...
...
-80     ...     95
...

Sum Between Min and Max: [Some calculated sum]
```

---

### 3. Caesar Cipher Encryption (`Program2.cs`)

A classic cryptography program that encrypts a user's message using the Caesar cipher.

*   **Purpose**: The user enters a string and an integer `key`. The program shifts each letter of the string forward in the alphabet by the `key` amount to encrypt it. The process correctly wraps around from 'Z' to 'A'.
*   **Concepts Demonstrated**: String and character manipulation (`ToCharArray`), static helper methods, conditional logic with `char.IsLetter` and `char.IsUpper`, and using the modulo operator (`%`) to perform circular shifts in an alphabet.

**Usage Example:**
```
Enter word:
Hello
Enter number:
3
New word: Khoor
```

## How to Run

You will need the .NET SDK to run these programs.

1.  **Create a Project Folder**: Open a terminal and create a new project.
    ```sh
    dotnet new console -o ArrayExercises
    cd ArrayExercises
    ```
2.  **Copy the Code**: Choose one of the programs (e.g., from `Program1.cs`) and copy its entire content.
3.  **Paste into `Program.cs`**: Open the `Program.cs` file that `dotnet` created in your project folder and replace its content with the code you just copied.
4.  **Run the Program**: In your terminal, execute the following command:
    ```sh
    dotnet run
    ```
You can repeat this process for each of the exercise files.
```

# C-Console-Project-Advanced-Calculator

A console-based C# application developed using .NET 10.0.  
This project is an advanced calculator system that demonstrates object-oriented programming, file handling, exception handling, and persistent data storage through a history management system.

---

## 📌 Project Overview

This application provides a fully interactive calculator with a menu-driven interface. It supports basic arithmetic operations and maintains a persistent calculation history saved to a file.

### Features:

- Addition, Subtraction, Multiplication, Division
- Calculation history tracking
- Save/load history from file
- Clear history functionality
- Input validation with error handling
- Persistent data storage using file system

---

## 🧠 Key Concepts Demonstrated

- Object-Oriented Programming (OOP)
- Classes and Objects
- Encapsulation
- Method design and reuse
- File I/O (`File.ReadAllLines`, `File.WriteAllLines`, `File.Delete`)
- Exception handling (`try-catch`)
- Loops and switch-based menu system
- Input validation using `TryParse`

---

## 🛠 Technologies Used

- C#
- .NET 10.0 SDK
- System.IO

---

## 📂 Project Structure

```bash
C-Console-Project-Advanced-Calculator/
│── Program.cs
│── Calculator.cs (optional structure concept)
│── calculator_history.txt (auto-generated)
│── C-Console-Project-Advanced-Calculator.csproj
│── README.md
```

---

## ▶️ How to Run

### Clone the Repository

```bash
git clone <your-repository-url>
```

### Navigate to Project Folder

```bash
cd C-Console-Project-Advanced-Calculator
```

### Run the Application

```bash
dotnet run
```

---

## 💻 Sample Output

```text
1. Addition (+)
2. Subtraction (-)
3. Multiplication (*)
4. Division (/)
5. View History
6. Save History
7. Clear History
0. Exit
-----------------------------------
Select an option: 1

Enter first number: 10
Enter second number: 5

Result: 10 + 5 = 15
```

---

## 📁 History System

The calculator automatically:

- Stores each calculation with timestamp
- Loads previous history on startup
- Saves history to `calculator_history.txt`
- Allows clearing stored history

---

## 🎯 Learning Objectives

- Advanced OOP design in C#
- Building menu-driven console applications
- Implementing persistent storage using files
- Handling runtime errors safely
- Using switch expressions and methods
- Structuring scalable console applications

---

## 👨‍💻 Author

Seam  
Full-stack Developer

---

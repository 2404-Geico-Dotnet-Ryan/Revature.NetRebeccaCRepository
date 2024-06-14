# C# Array and String Comparison

#### Fundamental Concepts

**Array Comparison**

- **Element-by-Element Comparison:** Compare two arrays by checking each corresponding element.

**Code Example:**
```csharp
int[] array1 = {1, 2, 3}; // Initialize the first array
int[] array2 = {1, 2, 3}; // Initialize the second array

bool areEqual = true; // Assume arrays are equal initially
if (array1.Length == array2.Length) // Check if both arrays have the same length
{
    for (int i = 0; i < array1.Length; i++) // Loop through each element
    {
        if (array1[i] != array2[i]) // Compare elements at the same index
        {
            areEqual = false; // If any element is different, set areEqual to false
            break; // Exit the loop
        }
    }
}
else
{
    areEqual = false; // If lengths are different, arrays are not equal
}
Console.WriteLine($"Arrays are equal: {areEqual}"); // Print the result
```

---

**Iteration**

- **For Loop and Foreach Loop:** Different ways to iterate through arrays.

**Code Example:**
```csharp
int[] numbers = {1, 2, 3, 4, 5}; // Initialize the array

// For Loop
for (int i = 0; i < numbers.Length; i++) // Loop through each index of the array
{
    Console.WriteLine(numbers[i]); // Print the element at the current index
}

// Foreach Loop
foreach (int number in numbers) // Loop through each element in the array
{
    Console.WriteLine(number); // Print the current element
}
```

---

**Equality Check**

- **Equality Operators and Methods:** Check if elements are equal using `==` or methods like `Equals`.

**Code Example:**
```csharp
string str1 = "Hello"; // Initialize the first string
string str2 = "Hello"; // Initialize the second string

bool isEqual = str1 == str2; // Using equality operator
Console.WriteLine($"Strings are equal: {isEqual}"); // Print the result

bool isEqualMethod = str1.Equals(str2); // Using Equals method
Console.WriteLine($"Strings are equal (using Equals method): {isEqualMethod}"); // Print the result
```

---

**LINQ Methods**

- **SequenceEqual Method:** Use LINQ for concise array comparison.

**Code Example:**
```csharp
using System.Linq; // Include LINQ namespace

int[] array1 = {1, 2, 3}; // Initialize the first array
int[] array2 = {1, 2, 3}; // Initialize the second array

bool areEqual = array1.SequenceEqual(array2); // Use SequenceEqual to compare arrays
Console.WriteLine($"Arrays are equal (using SequenceEqual): {areEqual}"); // Print the result
```

---

#### Intermediate Concepts

**Sorting Arrays**

- **Array.Sort Method:** Arrange elements in order.

**Code Example:**
```csharp
int[] numbers = {3, 1, 4, 1, 5, 9}; // Initialize the array
Array.Sort(numbers); // Sort the array

foreach (int number in numbers) // Loop through each element in the sorted array
{
    Console.WriteLine(number); // Print the current element
    // Outputs: 1 1 3 4 5 9
}
```

---

**Binary Search**

- **Binary Search Method:** Efficiently check if a number is present in a sorted array.

**Code Example:**
```csharp
int[] numbers = {1, 1, 3, 4, 5, 9}; // Initialize the sorted array
int target = 4; // Define the number to search for

bool found = Array.BinarySearch(numbers, target) >= 0; // Perform binary search
Console.WriteLine($"Number {target} found: {found}"); // Print the result
```

---

**Looping Constructs for Finding Missing Numbers**

- **Looping and Conditional Checks:** Iterate through sorted arrays to find the missing number.

**Code Example:**
```csharp
int[] numbers = {1, 2, 3, 5, 6, 7, 8}; // Initialize the array
Array.Sort(numbers); // Sort the array (if not already sorted)

int missingNumber = -1; // Variable to hold the missing number
for (int i = 0; i < numbers.Length - 1; i++) // Loop through the array
{
    if (numbers[i] + 1 != numbers[i + 1]) // Check if the next number is not consecutive
    {
        missingNumber = numbers[i] + 1; // Set the missing number
        break; // Exit the loop
    }
}

if (missingNumber == -1) // If no missing number found in the loop
{
    missingNumber = numbers[numbers.Length - 1] + 1; // The missing number is the next integer after the last element
}

Console.WriteLine($"Smallest missing number: {missingNumber}"); // Print the result
```
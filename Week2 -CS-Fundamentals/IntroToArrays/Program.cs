﻿﻿/*
Problem: There is a lot of DATA that exists!!!
Managing each piece in its own variable is going to become impractical
A lot of this data is quite similar or related whethers its by purpose or even Data Type.

We need introduce means to store multiple pieces of data within one device/variable.

Arrays -> offers a way for us to very simply store multiple values of the same Data Type.

DataType[] variableName = new DataType[size];

Arrays - in C# - have a fixed size upon instantiation (initialization).

Arrays use Indexes (just like Strings) -> An Array of size 5 - Indexes: 0-4
*/

// Basic Example
int[] numbers = new int[5]; // Create an Array that can hold 5 ints.

System.Console.WriteLine(numbers.Length);

//Assign a value to any *element* of this array
numbers[0] = 10;
numbers[1] = 11;
numbers[2] = 12;

// Recall/use said value stored inside any *element* of this array.
System.Console.WriteLine(numbers[0]);
System.Console.WriteLine(numbers[1]);
System.Console.WriteLine(numbers[4]);
// System.Console.WriteLine(numbers[10]); //IndexOutOfRangeException - acceptable indexes for this array are 0-4
// System.Console.WriteLine(numbers[-1]); //Cannot use negative indices (in c#)

System.Console.WriteLine(numbers);

// Foreach Loop
string arrString = "";
foreach (int num in numbers)
{
    arrString += num + ",";
}
System.Console.WriteLine(arrString);
arrString = arrString.Remove(arrString.Length - 1);
System.Console.WriteLine(arrString);


// string result = string.Join(", ", Array.ConvertAll(numbers, x => x.ToString()));

string[] numberStrings = new string[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    numberStrings[i] = numbers[i].ToString();
}
System.Console.WriteLine(string.Join(",", numberStrings));


//------------
System.Console.WriteLine("------------");
foreach (int num in numbers)
{
    System.Console.Write(num + " ");
}

// Even less Important
//Multi-dimensional Arrays
int[,] twoDimArray = new int[3, 3];
twoDimArray[0, 0] = 1;
twoDimArray[0, 1] = 2;

//-------- back to reality


// Alternative syntax for instantiating Arrays
string[] words = ["Hello World!", "Hi", "Hey"];
System.Console.WriteLine(words[1]);
//can still reassign
words[1] = "Bye";
System.Console.WriteLine(words[1]);
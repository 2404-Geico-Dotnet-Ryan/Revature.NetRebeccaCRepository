﻿/*
Problem: There is a lot of DATA that exists!!!
Managing each piece in its own variable is going to become impractical
A lot is quite similar or related whethers its by purpose or even Data Type.

We need introduce means to store multiple pieces of data within one device/variable.

Arrays -> offers a way for us to very simply store multiple values of the same Data Type.

DataType[] variableName = new DataType[size];

Arrays - in C# - have a fixed size upon instantiation (initialization)- when you give it is first valuse 

Arrays use indexes (just like strings) -> an array of size 5 has indexes 0-4
*/

//Basic Example (fixed size - hard coded)
//[] most important part of this formula indicates array and that determines how you code.
using System.Runtime.InteropServices;

int[] numbers = new int[5];// new - new keyword will talk about more later - used when creating any new object in C# telling application to reserve more memory for the project
// int [5] -- Create an array that can hold 5 ints. 
System.Console.WriteLine(numbers.Length);

//Assign a value to any *element* of this array 
numbers[0] = 10;  //this is an element of array and values 
numbers[1] = 11;
numbers[2] =12;

//Recall/use said value stored inside any *element* of this array. Element is a particular value inside an array.
System.Console.WriteLine(numbers[0]);
System.Console.WriteLine(numbers[1]);
System.Console.WriteLine(numbers[4]); //this will default to 0 since we have not assigned it
//System.Console.WriteLine(numbers[1]); // index out of range (acceptable is only 0-4)
//System.Console.WriteLine(numbers[-1]); not allowed in C# negative indexes(negative indices) 

System.Console.WriteLine(numbers); //this prints out System.Int2[] which is not what we want

// Foreach Loop -great for arranys to solve the above issue with print command 

foreach (int num in numbers)
{
    System.Console.WriteLine(num);
}
System.Console.WriteLine("---+-+-+-+-+--+");
// not right yet 
string arrstring = "[]";
foreach (int num in numbers)
{
    arrstring += num + ",";
}
System.Console.WriteLine(arrstring);

System.Console.WriteLine("-------------------");
//not right yet---
string arrString = "[";
foreach (int num in numbers)
{
    arrstring += num + ",";
}
System.Console.WriteLine(arrString);
arrstring = arrstring.Substring(0, arrstring.Length-1);
System.Console.WriteLine(arrString);
arrstring += "]";
System.Console.WriteLine(arrString);
//get full from trainer file
// option 1//string result = string.Join(", ", Array.ConvertAll(numbers, x => x))

//solution number 2 - c


// another option to print on one line each (easiest and simplist )
System.Console.WriteLine("**********");
foreach (int num in numbers)
{
    System.Console.WriteLine(numbers + " ");
}

// Even less important conversation on Arrays
//Multi-dimensional Arrays 
//Syntax
int[,] twoDimArray = new int[3,3]; //creates an Array that stores 3 arrays that can hold up to 3 elements each
twoDimArray[0,0] = 1;
twoDimArray[0,1] = 2;

//---- back to reality 

//Alterantive Syntax for instantiating Arrays (you have to provide all the values up front) these are fixed 

//This is ok for small list etc. but when there are too many possiblities need to go with something else
string[] words = ["Hello", "Hi", "Hey"]; //use can use [], {} - you can see either on an assessment
System.Console.WriteLine(words[0]); //0 is a choice of what you want to display 
//Can still reassign
System.Console.WriteLine(words[1]); // will show Hi
words[1] = "Bye"; //this changes 'Hi' to 'Bye'
System.Console.WriteLine(words[1]); // will show bye



   



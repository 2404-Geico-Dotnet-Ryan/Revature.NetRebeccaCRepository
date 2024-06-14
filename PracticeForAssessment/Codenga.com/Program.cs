// // https://codenga.com/articles/guides/csharp_four_practice_challenges_for_beginners
// /*
// 1. Implement an algorithm to sum together all the odd numbers in a collection. 
//     Here are the tests that your solution should pass:
//     new App().SumOdds(new int[]{1, 2, 3, 4, 5}) -> 9
//     new App().SumOdds(new int[]{1, 2, 3}) -> 4
//     new App().SumOdds(new int[]{2, 2}) -> 0
//     new App().SumOdds(new int[]{1, 1}) -> 2
// */
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//     }
//     int[] digits = [1,2,3,4,5,6,7,8,9];
//     int SumOdds(int[] digits)
//     {
//         int sum = 0;
//         foreach (int num in digits)
//         {
//             if (num  )
//             {

//             }
//             else
//             {

//             }
//             return sum;
//         }
//     }
    
// }


//Coding Challege on Array operations

// Check to see if 2 strings are equal


//me trying to put make work
// bool ForLoop (int[] firstArray, int[]secondArray)
// {
//     firstArray = [0,1,2,3,4,5,6,7,8,9,10];
//     secondArray =[10,9,8,7,6,5,4,3,2,1,0];
    
//     if (firstArray.Length != secondArray.Length)
//     //{Console.WriteLine("they are NOT equal");
//     return false;
//     //else
//     //{
//     for (int i =0; i < firstArray.Length; i++)
//         {
//             if(firstArray[i] != secondArray[i])
//             //Console.WriteLine("they are NOT equal");
//             return false;
//         }
//         //Console.WriteLine("they are equal");
//         return true;
//     //}
// }

//actual example
// public bool ForLoop(int[] firstArray, int[] secondArray)
// {
//     if(firstArray.Length != secondArray.Length)
//     return false;

//     for(int i = 0; i<firstArray.Length; i++)
//     {
//         if (firstArray[i] != secondArray[i])
//         return false; 
//     }
//     return true;
// }


// /////// ***********************************************************/////////
// //this works if the arrays are in the same order- not if in a different order 
// int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
// int[] array2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// bool areEqual = true; 
// if (array1.Length == array2.Length) 
// {
//     for (int i = 0; i < array1.Length; i++) 
//     {
//         if (array1[i] != array2[i])
//         {
//             areEqual = false; 
//             break; 
//         }
//     }
// }
// else
// {
//     areEqual = false; //
// }
// Console.WriteLine($"Arrays are equal: {areEqual}");

// // if they are in a different order in the second array //
// int[] array3 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
// int[] array4 = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
// bool equals = array3.OrderBy(a => a).SequenceEqual(array3.OrderBy(a => a));
// Console.WriteLine(equals);

// // this will work with spaces and string
// string str1 = "apple,banana,cherry";
// string str2 = "apple ,banana,cherry";
// string[] arr = str1.Split(',').Select(x => x.Trim()).ToArray();
// string[] arr2 = str2.Split(',').Select(x => x.Trim()).ToArray();
// bool areEqual1 = arr.SequenceEqual(arr2);
// Console.WriteLine(areEqual1);


// string[] str3 = { "apple", "banana ", "cherry" };
// string[] str4 = { " apple", "banana", "cherry" };
// string[] arr7 = str3.Select(x => x.Trim()).ToArray();
// string[] arr8 = str4.Select(x => x.Trim()).ToArray();
// bool areEqual3 = arr.SequenceEqual(arr2);
// Console.WriteLine(areEqual3);

//find smallest number that is greater than k which is not in the present array 

// int[] array5 = {1, 2, 3, 8, 15, 25, 11};
// int k =9;

// int min = notInArray5.Where(i => i> k).Min();
// System.Console.WriteLine(min);

// what if the array is string - this is not good if there is an extra space
// string str1 = "apple,banana,cherry";
// string str2 = "apple,banana,cherry";
// string[] arr1 = str1.Split(',');
// string[] arr2 = str2.Split(',');
// bool areEqual = arr.SequenceEqual(arr2);
// Console.WriteLine(areEqual);
// Console.WriteLine($"Arrays are equal: {areEqual}");


//****this will work for string arrays with space after the "" but not inside it
// String[] word1 = {"apple","banna", "orange", "watermelon", "kiwi"}; 
// String[] word2 = {"apple" ,"banna", "orange", "watermelon", "kiwi"};

// bool areEqual1 = true; 
// if (array10.Length == array12.Length) 
// {
//     for (int i = 0; i < array1.Length; i++) 
//     {
//         if (array10[i] != array12[i])
//         {
//             areEqual5 = false; 
//             break; 
//         }
//     }
// }
// else
// {
//     areEqual5 = false; //
// }
// Console.WriteLine($"Arrays are equal: {areEqual5}");

//what Amanda used for the comparing the 2 strings Passes 2 out of 3 test
// String[] word1 = {"apple","banna", "orange", "watermelon", "kiwi"}; 
// String[] word2 = {"apple" ,"banna", "orange", "watermelon", "kiwi"};

// static bool arrayStringsAreEqual (string[] word1, string[] word2)
// {
//     if (word1.Length == word2.Length)
//     {
//         for (int i =0; i < word1.Length; i++)
//         {
//             if (word1[i] != word2[i])
//             {
//                 bool result = false;
//                 break;
//             }
//             else
//             return true;
//         }
//     }
//     return false;
// }

//for the find next smallest number after K that is not in the array 
// int[] A = {1, 2, 3, 8, 15, 25, 11};
// int N = A.Length;
// int k =9;

// static int notInArray(int N, int[] A, int K)
// {
//     for (int i=K+1 ;i<=10000000000000;i++)
//     {
//         if(A[i2]==i)
//         {
//             found = true;
//             break;
//         }
//         if(!found)
//         return i;
//     }
//     return -404;
// }

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
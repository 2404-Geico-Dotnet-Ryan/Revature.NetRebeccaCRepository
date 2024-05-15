class PracticeChallenge
{
    // 0. Sample Solved Problem:
    // Return the sum of two integers.
    public static int Sum(int a, int b)
    {
        return a + b;
    }


    // 1. Calculate the average of all elements in an array.  ***need to test
    // Basic formula for average is <sum of all elements> / <number of elements>
    public static double ArrayAverage(double[] arr)

    {
        double average = arr.Average();
        return average;
    }

    // 2. Count the number of passing grades.
    // 'threshold' is the cutoff for a passing grade. If they are equal, then its passing.
    public static int CountPassingGrades(double[] grades, double threshold)
    {
        int countPassingGrades = 0;
        foreach (double grade in grades)
        {
            if (grade >= threshold)
            {
                countPassingGrades = countPassingGrades += 1;
            }
        }
        return countPassingGrades; // Placeholder return
    }

    // 3. Return true if the given number is a perfect square, otherwise false.
    // A Perfect Square means that the number is the product of squaring a Whole Number.
    // Example: 25 is a Perfect Square -> 5 * 5 = 25.
    public static bool IsPerfectSquare(int num)
    {
        for (int i = 1; i * i <= num; i++)
        {
            if (i * i == num)
                return true;
        }
        return false;
    }



    // 4. Return the count of distinct characters in a given string. Case-Sensitive -> A != a
    // Examples: "CAT" contains 3 distinct characters.
    // "Hello World" contains 8 distinct characters. "H,e,l,o, ,W,r,d"
    public static int CountDistinctCharacters(string str)
    {
        HashSet<string> characters = new HashSet<string>();

        string currentCharacter = "";

        for (int i = 0; i < str.Length; ++i)
        {
            if (Char.IsHighSurrogate(str, i))
            {
                // Do not count this, next one will give the full pair
                currentCharacter = str[i].ToString();
                continue;
            }
            else if (Char.IsLowSurrogate(str, i))
            {
                // Our "character" is encoded as previous one plus this one
                currentCharacter += str[i];
            }
            else
                currentCharacter = str[i].ToString();

            if (!characters.Contains(currentCharacter))
                characters.Add(currentCharacter);
        }

        return characters.Count;
    }


    // 5. Perform the FizzBuzz game up to a given number.
    // FizzBuzz game:
    // Return "Fizz" if number, 'n', is divisible by 3.
    // Return "Buzz" if number, 'n', is divisible by 5.
    // Return "FizzBuzz" if number, 'n', is divisible by both 3 and 5.
    // Return empty string, otherwise.
    public static string FizzBuzz(int n)
    {
        string result ="";
       
        if (n % 15 == 0)  //looked up and should be 15 because 3 and 5 multiplied is 15
        {
           result= "FizzBuzz";
        }
        else if (n % 5 == 0)
        {
            result= "Buzz";
        }
        else if (n % 3 == 0)
        {
            result="Fizz";
        }
        else
        {
        result = "";
        }
        
        return result;
    }


    // 6. Return the area of a triangle given its base and height.
    // Formula is Area = (1/2) * Base * Height
    public static double AreaOfTriangle(double base1, double height)
    {
        double area = (base1*height)/2; 
        return area; // Placeholder return
    }

    // 7. Return true if the given string is an anagram of another string, otherwise false.
    // An anagram of a string -> contains all the same characters, just in a different order.
    public static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false; //length is not same is not anagram
        }

        while (str1.Length > 0)
        {
            char c = str1[0];
            if (str2.Contains(c))
            {
                str1 = str1.Remove(0, 1);
                int index = str2.IndexOf(c);
                str2 = str2.Remove(index, 1);
            }
            else //no matching letter then not an anagram
            {
                return false;
            }
        }
        //if you make it here every letter had a match and now there are no letters left 
        return true; // Placeholder return
    }

    // 8. Count the frequency of words in a given string and return a frequency of each word.
    // In the Dictionary, Keys should be the words found. Values are their frequency.
    // Example: "Hello Hello World" -> Dictionary should have 2 Key-Value Pairs -> "Hello" : 2 and "World" : 1.
    // Consider using split() method on 'sentence' to divide it into smaller strings/words.
    public static Dictionary<string, int> CountWordFrequency(string sentence)
    {
        // should go through dictionary and count how many times each word is in there 
        //have to split into smaller strings/words
        
        return []; //Placeholder return
    }

    // 9. Reverse a given integer and add it to the original number.
    // Example: 123 -> Reversed: 321 -> 321 + 123 = 444
    // You can assume the numbers will be positive and not exceed the limit of int when added.
    public static int ReverseAndAdd(int num)
    {
        int reverseNum = int.Parse(new string(num.ToString().Reverse().ToArray())); //if int need to convert to string num.ToString() string reverse is different format than this
        return num + reverseNum;
    }

    // 10. Convert Age into Seconds
    // Given an Age (in years) return how old they were on their birthday in seconds.
    // Example: 1 year old -> 31536000 seconds.
    // Assume exactly 365 days / year for simplicity.
    // Using long to handle higher ages.
    public static long AgeInSeconds(long age)
    {
        return 0; //Placeholder return
    }

    // 11. Calculate the factorial of a positive integer.
    // Factorials are calculated as follows: 1 * 2 * 3 * ... * n
    // Factorial of 5 = 1 * 2 * 3 * 4 * 5 = 120
    // Assume the answer fits inside of an int data type. 
    public static int Factorial(int num)
    {
        return 0; //Placeholder return
    }


    // 12. Count how many times the record is broken in a list of scores.
    // Assume the scores represent a chronological order in which they were earned.
    // First number counts as the first broken record. Then every new highest number after that.
    // Example: scores -> [100, 105, 200, 150, 250, 200] -> The record is broken 4 times. 
    // Starting with 100, then 105, then 200, then 250.
    public static int CountRecordBreaks(List<int> scores)
    {
        return 0; //Placeholder return
    }

    // 13. Compare Apples to Oranges
    // Apples and Oranges are...not like each other. But we could still compare them!
    // Implement the CompareToOrange() method such that an Apple and Orange 
    // are considered equal if their same named properties are equal.
    public class Apple
    {
        public int Weight { get; set; }
        public string? Color { get; set; }

        public bool CompareToOrange(Orange orange)
        {
            return false; //Placeholder return
        }
    }
    public class Orange
    {
        public int Weight { get; set; }
        public string? Variety { get; set; }
    }

    // 14. All Cars are now Black!
    // Add a constructor below such that all cars are now Black.
    // (Is already so, but) ensure that you cannot change the color away from Black.
    public class Car
    {
        public string? Color { get; }

    }

    // 15. Same Numbers, Different Set
    // Return all the numbers shared by the two sets.
    // Example: set1 -> [1, 2, 3, 4] - set2 -> [3, 4, 5, 6] - returns -> [3, 4]
    public static HashSet<int> CompareSets(HashSet<int> set1, HashSet<int> set2)
    {
        return []; // Placeholder return
    }
}
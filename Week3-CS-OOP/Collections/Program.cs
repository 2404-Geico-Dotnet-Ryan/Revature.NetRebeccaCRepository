using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        //Lists();
        //StacksAndQueues();
        //HashSets();
        Dictionary();
    }

    private static void List()
    {
        //Collection over the word data structure(Aray)
        //they can adjust to add new size - dynamic size
        //Arrays are a fixed size-- could have holes where no values are assigned
        //no holes - all entries have an assigned values 


        //Data Structure -> Arrays
        //int[] numbers = new int[5]
        //string[] words = new string[5]

        //Collections 
        // List 
        //(List is an array) -> stores all of its' values inside an array 

        //Parameterized Class ...
        //Generics - Generic Class
        //DataType<elementType> variableName = new DataType<elementType>();
        //instatition on this side             initaliation on this side
        //

        List<int> numbers = new List<int>(); //most proper way to type it out can leave out List<int> in intitalition
        // could also use List<int> = [];

        //Add Values 
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //printing out items in a collection (same for arrays)

        //Long way 
        System.Console.WriteLine("printing each on separate lines");
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num);
        }

        //one liner
        System.Console.WriteLine("printing all on one line separated by ,");
        System.Console.WriteLine(string.Join(",", numbers));


        //Inserting Value somewhere other than at end of list;
        System.Console.WriteLine("Inserting number at beginning of list");
        numbers.Insert(0, 40);
        //numbers.Insert (<locationinarray>, <Value adding to array>)
        System.Console.WriteLine(string.Join(",", numbers));

        System.Console.WriteLine("Add/insert multiple Values");
        //Add/Insert multiple values 
        //Another list
        List<int> numbers2 = [1, 2, 3];
        numbers.AddRange(numbers2);
        numbers.InsertRange(0, [4, 5, 6]);
        System.Console.WriteLine(string.Join(",", numbers));

        System.Console.WriteLine("Finding location(postition) of the Index in an array");
        //IndexOf
        System.Console.WriteLine(numbers.IndexOf(30));
        System.Console.WriteLine("Finding if a number is in the range");
        System.Console.WriteLine(numbers.Contains(25));

        //Accessing an element--
        System.Console.WriteLine("Printing specific index in the range");
        System.Console.WriteLine(numbers[0]);//prints 1st number in range

        //Remove an element 
        System.Console.WriteLine("removing items from list");
        numbers.Remove(20); //removing number 20 from list
        numbers.RemoveAt(0); //removing number in the 1st position in the list
        System.Console.WriteLine(string.Join(",", numbers));

        //Reversing the list
        System.Console.WriteLine("reverse a list");
        numbers.Reverse();
        System.Console.WriteLine(string.Join(",", numbers));

        //The above are methods used to impact the list permenantly

        //review other methods available just to familiarize 
        System.Console.WriteLine("Sorting numbers in a list");
        numbers.Sort();
        System.Console.WriteLine(string.Join(",", numbers));

        //Self Study : IComparable<datatype> -> 
        //see how you can add it to your own classes like cars to allow them to be sorted
        //like strings using a comparer interface
    }

    private static void StacksAndQueues()
    {
        //There are more collections than just lists. 
        //Stacks and queues take a different strategy to data storage
        //they see it as a holding cell where data enters in a particular order
        //and exists (leaves or removed) in a particular order.
        //Not for longterm storage -they go in and then we remove them as we process them

        //Stacks have a strategy called First In, Last Out  (FILO) bottom up processing
        //Queues have a strategy called First In, First Out (FIFO) top down processing
        //there are priority queues as well -- as an extra study if needed 
        System.Console.WriteLine("Creating queue");
        Queue<int> queue= new();
        System.Console.WriteLine("adding to queue");
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue(); //removes first enqueue
        queue.Enqueue(4);
        //can't really print what is in the queue

        System.Console.WriteLine("Removing from queue");
        while (queue.Count > 0)
        {
            System.Console.WriteLine("Dequed: " + queue.Dequeue());

        }

        //Stacks 

        Stack<int> stack = new();

        stack.Push (10);
        stack.Push (20);
        stack.Push (30);
        System.Console.WriteLine("First Popped item; " + stack.Pop()); //removesonly 1
        stack.Push(40);
        //will remove everything 
        while (stack.Count >0)
        {
            System.Console.WriteLine(" Popped item; " + stack.Pop());
        }
               

    }
    private static void HashSets()
    {
        //Hash is just a way of storing values - usually using some of the items information 
        //data to help formulate a spot for the hash to store said item 
        //This is useful for classes like cars when you want just year models for example 
        

        //Set - does not perserve any order insertion 
        // - duplicates are not allowed.

        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(4);
        set.Add(5);
        set.Add(5); //if you add duplicate it will ignore it
        System.Console.WriteLine("Checking to see if something is in the set");
        System.Console.WriteLine(set.Contains(4));//returns True if in set and False if not
        System.Console.WriteLine("Printing each number in set");//may not be in order though- not sorted but could be in another order
        foreach (int num in set)
        {
            System.Console.WriteLine(num);
        }
        //you can join sets etc. this is not a focus//
        //you can get this from his code but not needed
        HashSet<int> set2 = [2,3,4,7,10];
        set.UnionWith(set2);
        System.Console.WriteLine(string.Join("'",set2));
        //Intersect show what is common in both sets
    }

    private static void Dictionary()
    {
        //Dictionaries store  Key Value Pairs
        //Two data types you have to pick (one for key and one for value)
        //Real world examples - Dictionary, word to the definition 
        // you look up the word(key) and it provides you with the definition (value)
        //OR SSN 
        //SSN acts as a key then a computer can map it to information traced back to you

        Dictionary<string, int> studentScores = new Dictionary<string, int>();
        studentScores.Add("Becky", 0);
        studentScores.Add("Brandon", 70);
        studentScores.Add("Lannette", 100);
        studentScores.Add("Sam", 90);

        //Accessing elements in Dictionary 
        //assumption is that you know the key 
        System.Console.WriteLine("Ryan's Score: "+ studentScores["Ryan"]);
        studentScores["Ryan"]= 81;
        System.Console.WriteLine("Ryan's Score: "+ studentScores["Ryan"]);
        //to see if
        System.Console.WriteLine(studentScores.ContainsKey("Ryan"));
        //Throws exception if not a key in dictionary 
        System.Console.WriteLine("Bob's Score: "+ studentScores["Bob"]);
        //How to print each item in Dictionary
        foreach (KeyValuePair<string, int> keyValuePair in studentScores)
        // introducting Var - where you do not have to worry about the data type
        //Can write like this Foreach (var kvp in studentScores)
        {
            System.Console.WriteLine(keyValuePair.Key + ":" + keyValuePair.Value);
        }

        
    }
}

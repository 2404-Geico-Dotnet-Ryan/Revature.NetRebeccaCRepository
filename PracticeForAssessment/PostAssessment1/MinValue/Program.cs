 public static void Main()
 {
        string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
        int[] intArray = new int[inputArray.Length];
        for(int i=0;i<intArray.Length;i++){
        intArray[i]=Int32.Parse(inputArray[i]);
        }
        Console.WriteLine(findMin(intArray));
    }

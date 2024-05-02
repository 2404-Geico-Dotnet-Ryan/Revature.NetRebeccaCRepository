using System;

class Program
{
    static void Main(string[] args)
    {
        // clash1
        //Ryan
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 0) Console.WriteLine(n*2);
            else Console.WriteLine(n*3);
        }
        //Katherine Piper
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n %2 == 0)
            {
                int even = n*2;
                Console.WriteLine(even);
            }
            else
            {
                int odd = n*3;
                Console.WriteLine(odd);
            }
        }
        //Lanette
         int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int remainder = n%2;   //this is what figures out what is even or odd
            int answer = 0;

            if (remainder == 0)
            {
                answer = n*2;
            }
            else 
            {
                 answer = n*3;
            }
            Console.WriteLine(answer);
        }

        

    }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        //Removed the strings practice and instead wanted to save/tweak my
        //code challenge 1 answers
        //This was an example given in the coding challenge
        int b = 9;
        int s = 2;
        int t = 3;

        //This is where the coding challenge answer I did starts:
        int rocksremaining = b;
        int srocks = 0;
        int trocks = 0;
        int turncount=1;
        int answer;
        
    //find count of 2nd to last turn
     do 
        {
            if (turncount%2 == 0)
            {
                rocksremaining = rocksremaining - t;
                turncount++;
            }
            else
            {
                rocksremaining = rocksremaining - s;
                turncount++;
            }
        
        } while (rocksremaining >0);
        //during the test, i put >= 0 

        int secondtolastturncount = turncount - 2;
    
        
        //if the last 'full turn' was Steve, then game will end with Tommy
        //if the last 'full turn' was Tommy, then game will end with Steve
        if (secondtolastturncount%2 == 0)
        {
            srocks = ((s*secondtolastturncount)/2) + (s+rocksremaining);
            answer = srocks;
        }
        else 
        {
            trocks = (t*(secondtolastturncount-1)/2) + (t+rocksremaining);
            answer = trocks;
        }
        
        //In coding challenge:  return answer;

        //This is just for us to display right now, but you wouldn't
        //include this console.writeline statement
        //in the coding challenge
        Console.WriteLine(answer); 

    }

    public static int RyansSolution() //hint int requires a return
    {
        
        int steveRocks =0; //goes first
        int tommyRocks =0;

        //Taking out the rocks
        //simultaniously check to see if they can take out a full set 
        //if rocks left >0 then move to next person turn
        //Could be multiple turns
        while (b>0)
        {
            //Steve Turn 
            if (b > s)
            {
                b -= s;
                steveRocks += s;
            }
            else
            {
                steveRocks += b;
                return steveRocks;
            }
            //Tommys Turn
            if (b > t)
            {
                b -= t;
                tommyRocks += t;
            }
            else
            {
                tommyRocks += b;
                return tommyRocks;
            }

        }
        //return the number of rocks from the last person to go 
       return 0;
    }
}

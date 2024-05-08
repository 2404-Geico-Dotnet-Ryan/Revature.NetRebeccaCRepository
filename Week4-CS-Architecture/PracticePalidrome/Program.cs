using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //use resource from Ryan's Class Chat
    static void Main(string[] args)
    {
        isStringPalidrome();
       // anotherStringPalidromeTry();
    }  

    

    private static void isStringPalidrome()
    {
        string str = "madam";
        char[] cArray = str.ToCharArray();
        Array.Reverse(cArray);
        string revStr = new string(cArray);
        Console.WriteLine(str == revStr ? "true" : "false");
    }

    private static void anotherStringPalidromeTry()
    {
        string _inputstr, _reversestr = string.Empty;  
    Console.Write("Enter a string : ");  
    _inputstr = Console.ReadLine();  
    if (_inputstr != null)  
    {  
        for (int i = _inputstr.Length - 1; i >= 0; i--)  
            {  
            _reversestr += _inputstr[i].ToString();  
            }  
            if (_reversestr == _inputstr)  
            {  
            Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);  
            }  
            else  
            {  
            Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);  
            }  
        }  
        Console.ReadLine();  
    }

    private static bool booleanStringPalidrome(Char[] word)

    {
        
        int i1 = 0;
        int i2 = word.Length -1;

        while (i2> i1)
        {
            if (word[i1]!= word[i2])
            {
                return false;
                System.Console.WriteLine("This is not palindrom");
            }
            ++i1;
            --i2;
        }
        return true;
        System.Console.WriteLine("This is a palindrom");
    }

}
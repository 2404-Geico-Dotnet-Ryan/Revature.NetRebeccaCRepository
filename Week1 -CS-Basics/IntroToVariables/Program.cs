// See https://aka.ms/new-console-template for more information
//This is your go-to line of code for printing to console
//Console.WriteLine("Hello, World!"); //End of Line Comments ok must start new line for new code
//Console.WriteLine("Hello, World!"); //prints Hello, World

//Variables - are designed to hold data/informration within our application for additional later use.

// Variables Declaration - we are telling our application to create this variable in memeory (set aside something in memory for the variable)
// Syntax: DataType (single word statement) nameOfVariable;
// Data Types - indicate what kind of infomration is allowed to be stored within that particular variables
// "Primitive" Data Types - admittedly C# refers to primitive as "Structs" 
//   - Serve ONE purpose. Holding a single valuse
//   - in C# we call these value-types (VS reference-Types)
//   - Numerical value-types: (
//      sbyte(signed byte- is C# going to store negative numbers would be -128 through 127), 
//      byte, 
//      short (signed - meaning have negative numbers), 
//      ushort(not signed (Unsigned) meaning no negatives), 
//      int, unt, long (similiar to Bigint),ulong, 
//      float(32bytes), double (64 bytes), - these are meant for decimal numbers difference is how they are stored float and double are stored as scientific notation but displays normally
//      decimal -(128 Bytes))
// int and double and sometimes long will be used in class
//   - C# defaults to INT- which satisfies most coding
//          1 - Number literal - physically typing some number into your code. 
//   - Non Numerical value-types: (char,bool, enum, struct)
//          we will use:
//          Boolean - conditional logic or logic gates -holds true or false values (expressions evaluate to a true or false)
//          Char - string of characters letters symbols etc. "Hello World!" has 15 characters
//          emu - creaete values (days of the week is an example)(other examples - Roles like User, Adim, Supv, director etc)
//          struct- not talking about this right now to heavy for now


//actually creating variables in class
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
int number;//variables must be camelCasing- shouldnot be too detailed try to stick to one word
// variable assignment 
//Syntax: VariableName = some-value;
number = 10; // stored in binary displays normal

int numberOfBooks;
numberOfBooks = 10; // hard coded values - most of time has ...
numberOfBooks = 11; //Re-assingment

Console.WriteLine(numberOfBooks);//this description and variable gives context to what is being printed
Console.WriteLine(number);

// variable declaration and assignment (=) at same time - this should be common practice
double money = 2.5; //no need to creat 0 at end -- set money to 2.5
// = is the assignment operator
System.Console.WriteLine(money); //cw - shortcut - hit enter then do not streann over the system. addition to the script


//Basic Operations - spaces have no impact on code but can complicate view if to many (binary operators)

int num = 1 + 2;
num = 1 - 2;
num = 1 * 3; //not an x and no ()
num = 1 / 3; //These are whole numbers in int and will keep whole number for output - this will not be decimal displayed--Integer division
num = 1 % 3; //this is called Modulus - what is the remainder of 1 / 3 (how many are left over so this would be 1 as three does not go into 1)
// static - can not change once declared int to double -- you would have create a variable for new 

System.Console.WriteLine(num);

double num2 = 1 / 3.0;
System.Console.WriteLine(num2);
System.Console.WriteLine(0.1 + 0.2);

//Augmented (Compund) Assignment Operators - if yu want to perform a calculation on a variable and store that result back into the variable
//(binary operators)

int num3 = 10;
int result = num3 * 3;
//num3 = num3 * 3; //this is the new value for num3 so if do the same will be 90 
// this is just short hand
num3 = num3 + 5;
num3 -= 10;
num3 *= 2;
num3 /= 2;
num3 %= 2;


System.Console.WriteLine(num3);
System.Console.WriteLine(num3 + 5); // does not affect the num3 variable
System.Console.WriteLine(num3);

//Increment/Decrement Operators-- Just another shortcut
num3++;//increment - add extactly 1        -> numb +=1;     -> num3= num3 + 1;
num3--; //decrement - subtract exactly 1  -> numb3 -= 1;   -> num3= num3 - 1;

++num3;
--num3;

System.Console.WriteLine(num3);

//Augment Assignment Operator
num3 += 5; //exactly as (num3 + 5); 
System.Console.WriteLine(num3);
//placement of ++ determines pre or post increment
System.Console.WriteLine(num3++); // this is only used occassionally post (after) -increment - will display once second line run --increments after the initial to run
System.Console.WriteLine(num3);
System.Console.WriteLine(++num3); //used more oftenthen runs before second command pre-increment - does not need second command

// Booleans - a primtive value type that stores 'true' OR 'false'

bool isSunny = true;
bool isRainy = false;

System.Console.WriteLine(isSunny); //prints True

// !  -> Null Operator (Negate or Negationn) -> changes the boolean into it 'opposite' value. without changing the value of sunny.
// unary operator
System.Console.WriteLine(!isSunny);  // means is NOT sunny 
isSunny = !isSunny; //a toogle switches value to opposite value 

System.Console.WriteLine(isSunny); //prementantlychanges value - should print false

// Relational Operators - compare one value to another value. Binary Operators 
//  some examples == (equality operator), != (not equal to eachother), <, >, <=, >=

System.Console.WriteLine(5 == 5);  //Boolean expression  -> expression that evaluate to true or false and prints this out
System.Console.WriteLine(numberOfBooks == 5); // this should be false as number of books final from code above is NOT 5
System.Console.WriteLine(numberOfBooks != 5); // this should be print true as number of books is not 5 
System.Console.WriteLine(numberOfBooks >5); //true
System.Console.WriteLine(numberOfBooks <5); //false
System.Console.WriteLine(numberOfBooks >=5); //true
System.Console.WriteLine(numberOfBooks <=5); //false

//GET ahead step -> logical operators, condition statements, loops
//Other topics -> strings, concatentation, Maybe lists (arrays) 

//Stop for class Day 3//




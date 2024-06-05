"use strict"

console.log("Hello World!");

// Data Types

/*
    in statically typed languages like C# you must declare the data type of the variable first before you can even assign it something

    string  name = "Mike";
    name = 3;

    primitive types 
    string 
    number
    boolean 
    null
    undefined
    symbol
    bigInt

    reference types 
    object
    array 
    function 
*/

let name ="John"; //string 
let age = 30; // number
let isStudent = false; //boolean
let car= null; //null
let address; //undefined


//Symbol is used to create unique things even with the same values 
let uniqueID = Symbol(1); 
let uniqueID2 = Symbol(1);
console.log(uniqueID==uniqueID2);

let largeNumber = 12345614231456431254n; //bigint

//You can reassign variables to any data, it is loosely typed
age="50";
console.log(name);
console.log(age);
console.log(address);

//Object
// the syntax is very similar to JSON
//it begins with {} and the properities inside of it follow a key value pair
let person =
{
    name: "John",
    age: 30
};
greet();
console.log(person);

//Array
//arrays can have any data type within it it is not restricted
//generally it is recommended to stick with one, but if you need mutliple that is fine

let hobbies = ["reading", "writing", 32342, null];
console.log(hobbies); 


//Function
//you don't define what it returns
// just use function, the name of the function, and the parameters
function greet()
{
    console.log("Hello");
}

greet(); //this is how you call the function - similiar to a method but not
// involing - calling the function 

//javascript treats everything like an object
//losely typed language

//Type Coercion
/*
    JavaScript will automatically convert values from one type to another when neccessary. 
    This is type coercion and can lead to unexpected results if not handled carefully.
*/
console.log("6"*6); //66 string concatenated 
console.log("5"-2); //number returns 3
console.log("5"*"2"); // 10 (number)
console.log("five"*2); //NaN not a number error

//Type of
// you can use the typeof operator to check what the datatype of a variable is
console.log(typeof person); //object
console.log(typeof NaN); //not a number is a number 
console.log(typeof null); //object

//Variable Scopes

//Function Scope
    // variables declared inside a function is scoped to that function
//Block Scope
    //variables declared with let or const are scoped to teh block in which they are defined {}


/*
    There are 3 ways to declare a variable in Javascript

    The first way was the first to be introduced into the language when it was created 

    Var 
    var does something called variable hoisting (moving declartion but not initialization)
    anything declared with var when it is ran all the declarations will be brought to top of the page but not the initialization 
    so the variable can be referenced after it has been declared, but it will be undefined. This leads to broken code most of the time 

    After some time, ECMA decided to include let and const let and const did away with variable hoisting and it is the recommended way to declare variables in javascript
*/
console.log(name2); // if called here will be undefined - 

var name2 = "let";
/*
 anything declared with let and const has block scope
 this means that you cannot reference outside teh scope that it is declared in

*/

{
    let uniqueName = "Greg";
    const secondName ="Mike";
    var name3 ="Jeff";
}
//console.log(uniqueName); will throw error outside block
//console.log(secondName); will throw error outside block
console.log(name3); //will not throw error does not have block scopes


/*
    let and const have other properties 
    let is basically the default declaration for a variable 
    it lets anything declared to be reassigned
    it also lets you declare it without initializing a variable 
    with it, you don't have to assign a value to it 

    Const
    const is used for constants and when a value has been assigned to it and it cannot be reassigned to something else 
    Anything declared with const must also be initialized you cannot have undefined values for const
*/

//Arrays 
/*
    Used to store multiple values in a single variable
    They also provide various methods for adding, removing, and manipulation elements
*/

let fruits = ["apple", "banana", "orange"];

//access the values of the array wiht indexes
console.log(fruits[0]); //apple

//if you want to add an element to the end of an array 
//push
fruits.push("grape");

console.log(fruits);

//if you want to remove the last element of the array 
//pop
fruits.pop();
console.log(fruits);

//Loops
//they are 3 ways to loop in a for loop types in JavaScript

//default for loop 
for (let i =0; i<fruits.length; i++)
    {
        console.log(fruits[i]);
    }
//for of
//this loop with 
for (const element of fruits)
    {
        console.log(element);
    }

//for in 
//this loop will go through each key of the array/object
for (const key in person)
    {
        console.log(key);
        //add notes 
        console.log(person[key]);
    }


//Functions
/*
    These are blocks of code designed to perform a particular

*/
function greetPerson(name)
{
    return "hello, "+ name;
}
console.log(greetPerson("Mike"));

//function expressions -- this is most common and you can interchange const and let here - let though is more common 
//because we are declaring a value and then assigning it a function, we can reassign it if we want to 
let greetPersonExpression = function(name)
{
    return "Hello, " + name;
}
//this let makes it able to be reassigned
greetPersonExpression = function(name)
{
    return "Hello again, " + name
}
console.log(greetPersonExpression("Jim"));

//OOP
/*
    OOP is supported somewhat in JavaScript
    The language already has objects in it but there is no in built class features
    this is what we call syntactic sugar, where we have syntaxes that look like it is doing something but when it is ran through the compiler, it is converted into something else
*/

class Person
{
    constructor(name, age)
    {
        this.name = name;
        this.age = age;
    }
    greet()
    {
        console.log("Hello, my name is " + this.name);
    }
}
const john = new Person("John", 30);
john.greet();
console.log(john);

//this keyword
/*
    this refers to the current context in which a function is executed 
    its value depends on how a function is called 
    if the function is inside of an object then this refers to the object that is being called 
    if the function is outside of an object then this refers to teh global object which is the browser
*/

function globalGreet()
{
    console.log(this);
}
globalGreet();

//Arrow functions
/*
    Arrow functions provide a shorter syntax for writing functions 
    They are specifically useful for inline functions 
    They also have a unique property, in which, they do not bind their own this
*/

//Function Expression 
let add = function(param1, param2)
{
    return param1 + param2;
};
// it will implicitly return this value on the right side
add=(param1, param2) => param1+param2;
console.log(add(1,2));

const Mike= 
{
    name: "Mike",
    greet: () => 
        {
            console.log("Hello, my name is " + this.name);
        }
};
Mike.greet();
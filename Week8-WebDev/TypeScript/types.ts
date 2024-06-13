// Simple Types
/*
    We have basic types with TypeScript
    string
    number
    boolean
    null
    undefined

    The syntax for typing in typescript is the following

    let referenceName : type = value;

    in C# the syntax was this:

    type referenceName = value;
*/

let isDone: boolean = false;
let age: number = 26;
let firstName: string = 'John';
let u: undefined = undefined;
let n: null = null;

// You cannot reassign a value to something that does not match its declared datatype

// isDone = "Hello";
// You can do this, and still run the transpiler to get JS and the JS file will still work
// However, this kind of behavior defeats the point of even having typescript in the first place


// Arrays
// syntax
// The typing allows us to now have typesafety in our arrays
// type[] or Array<type>

let numberList: number[] = [1, 2, 3];
let genericNumberList: Array<number> = [1, 2, 3];


// Tuple
// Tuples let you define an array with fixed types and length

let tupleExample: [string, number];
tupleExample = ["Hello", 50]; // correct
// tupleExample = [10, "hello"]; // error

// Enums
// Enums allow you to define a set of named constants

// numerical enum
// Basically you can think of this as a predefined array where the indexes are actually values
enum Color {
    Red,
    Green,
    Blue
}

enum StatusCodes {
    Ok = 200,
    Created = 201,
    NotFound = 404
}

let colorExample: Color = Color.Green;
console.log(colorExample); // 1


// String enums
// You must define every single value, there is no default values for string enums
enum CardinalDirections{
    North = "NORTH",
    East = "EAST",
    South = "SOUTH",
    West = "WEST"
}

let direction: CardinalDirections = CardinalDirections.North;
console.log(direction); // NORTH

// Any
// any type lets you opt-out of type checking
// This gives you loose typing just like in JavaScript

let notSure: any = 5;
notSure = "Hello";
notSure = false;


// void
// the void type is used for functions that do not return a value

function sayHello() : void {
    console.log("Hello!");
}

// never
// never represents values that never occur
// It is used for functions that always throw an error or never return

function error(message: string): never {
    throw new Error(message);
}
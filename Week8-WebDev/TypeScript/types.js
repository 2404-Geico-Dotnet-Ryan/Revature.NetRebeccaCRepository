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
var isDone = false;
var age = 26;
var firstName = 'John';
var u = undefined;
var n = null;
// You cannot reassign a value to something that does not match its declared datatype
// isDone = "Hello";
// You can do this, and still run the transpiler to get JS and the JS file will still work
// However, this kind of behavior defeats the point of even having typescript in the first place
// Arrays
// syntax
// The typing allows us to now have typesafety in our arrays
// type[] or Array<type>
var numberList = [1, 2, 3];
var genericNumberList = [1, 2, 3];
// Tuple
// Tuples let you define an array with fixed types and length
var tupleExample;
tupleExample = ["Hello", 50]; // correct
// tupleExample = [10, "hello"]; // error
// Enums
// Enums allow you to define a set of named constants
// numerical enum
// Basically you can think of this as a predefined array where the indexes are actually values
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var StatusCodes;
(function (StatusCodes) {
    StatusCodes[StatusCodes["Ok"] = 200] = "Ok";
    StatusCodes[StatusCodes["Created"] = 201] = "Created";
    StatusCodes[StatusCodes["NotFound"] = 404] = "NotFound";
})(StatusCodes || (StatusCodes = {}));
var colorExample = Color.Green;
console.log(colorExample); // 1
// String enums
// You must define every single value, there is no default values for string enums
var CardinalDirections;
(function (CardinalDirections) {
    CardinalDirections["North"] = "NORTH";
    CardinalDirections["East"] = "EAST";
    CardinalDirections["South"] = "SOUTH";
    CardinalDirections["West"] = "WEST";
})(CardinalDirections || (CardinalDirections = {}));
var direction = CardinalDirections.North;
console.log(direction); // NORTH
// Any
// any type lets you opt-out of type checking
// This gives you loose typing just like in JavaScript
var notSure = 5;
notSure = "Hello";
notSure = false;
// void
// the void type is used for functions that do not return a value
function sayHello() {
    console.log("Hello!");
}
// never
// never represents values that never occur
// It is used for functions that always throw an error or never return
//this is generally used if they can't get code to work 
function error(message) {
    throw new Error(message);
}

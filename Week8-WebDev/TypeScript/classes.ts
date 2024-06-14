// Classes
/*
    Classes in TS are a blueprint for creating objects with predefined properties and methods
    TS classes support things like:
        - Inheritance
        - Access Modifiers
        - Constructors
*/

class Animal {
    private name: string;

    constructor(name: string){
        this.name = name;
    }

    public move(distance: number): void {
        console.log(`${this.name} moved ${distance} yards.`);
    }
}

class Dog extends Animal {
    constructor(name: string){
        super(name);
    }

    public bark(): void{
        console.log("Woof! Woof!");
    }
}

const dog = new Dog('Buddy');
dog.bark(); // Woof! Woof!
dog.move(10); // Buddy moved 10 meters

// Casting
// Casting is when you tell the compiler to treat a variable as a different type

let someValue: any = "This is a string";
let strLength: number = (someValue as string).length

// Union Types
// Allow a variable to be one of several types
let unionValue: string | number | boolean;

unionValue = "hello";
unionValue = 42;
unionValue = false;
// unionValue = null;


// Interfaces and Type Aliases

// type aliases
// type aliases let you create a new name for a type

type StringOrNumber = string | number;

let value: StringOrNumber;
value = "string";
value = 123;

// Interfaces let you define the structure of an object

interface Person {
    firstName: string;
    lastName: string;
    age?: number; // optional property
}

function greetPersons(person: Person): string {
    return `Hello, ${person.firstName} ${person.lastName}`;
}

let user: Person = {firstName: "Mike", lastName: "Jones"}; // this is fine because age is optional


// object types
// This is another way to describe the shape of an object
// You don't have to make an interface

type UserObj = {name: string, age?: number};

let userObj: UserObj = {name: "Alice", age: 33};


// Intersection Types
// These combine multiple types into one

interface Employee {
    employeeId: number;
}

type OfficeWorker = Person & Employee;

let worker: OfficeWorker = {firstName: "John", lastName: "Doe", employeeId: 1123};


// Literal Types
// This lets you specify exact values a variable can be

type Direction = "north" | "south" | "east" | "west";

let move: Direction;
move = "north";
// move = "up"; // error


// Type Guards
function isNumber(value: any): boolean {
    return typeof value === "number";
}

function printValue(value: string | number) {
    if (isNumber(value)) {
        console.log((value as number).toFixed(2)); // TypeScript knows `value` is a number here
    } else {
        console.log((value as string).toUpperCase()); // TypeScript knows `value` is a string here
    }
}




//Generics
/*
     Generics provide a way to create reusable components that work with a variety of types.

     These can be functions, classes, methods, etc.

*/

//simple example 
//Through convention <T> it stands for type but this could be anything - then goes to U then V
//for pairs it would be K and V (key and Value)
// this is a placeholder for them to provide a type of data
function identity<T>(arg: T): T {
    return arg;
}

let output1 = identity<string>("Hello");
let output2 = identity<number>(35);

class Box<T> {
    private field: T;
    constructor (field :T)
    {
        this.field = field;
    }
}

// console.log(output1); // Output: Hello
// console.log(output2); // Output: 42

//Array Generics
//Generics can also be used with arrays to ensure type safety.

function getArraySorted<T>(items: T[]): T[] {
    return new Array<T>().concat(items);
}

let numArray = getArraySorted<number>([134, 2342, 32, 124]);
let strArray = getArraySorted<string>(["ass", "ber", "casdf"]);

// numArray.push(5); // OK --- did not due in class
// strArray.push("d"); // OK -- did not due in class

console.log(numArray);
console.log(strArray); 
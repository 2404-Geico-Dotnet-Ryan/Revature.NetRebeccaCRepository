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

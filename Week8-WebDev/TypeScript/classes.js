// Classes
/*
    Classes in TS are a blueprint for creating objects with predefined properties and methods
    TS classes support things like:
        - Inheritance
        - Access Modifiers
        - Constructors
*/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Animal = /** @class */ (function () {
    function Animal(name) {
        this.name = name;
    }
    Animal.prototype.move = function (distance) {
        console.log("".concat(this.name, " moved ").concat(distance, " yards."));
    };
    return Animal;
}());
var Dog = /** @class */ (function (_super) {
    __extends(Dog, _super);
    function Dog(name) {
        return _super.call(this, name) || this;
    }
    Dog.prototype.bark = function () {
        console.log("Woof! Woof!");
    };
    return Dog;
}(Animal));
var dog = new Dog('Buddy');
dog.bark(); // Woof! Woof!
dog.move(10); // Buddy moved 10 meters
// Casting
// Casting is when you tell the compiler to treat a variable as a different type
var someValue = "This is a string";
var strLength = someValue.length;
// Union Types
// Allow a variable to be one of several types
var unionValue;
unionValue = "hello";
unionValue = 42;
unionValue = false;
var value;
value = "string";
value = 123;
function greetPersons(person) {
    return "Hello, ".concat(person.firstName, " ").concat(person.lastName);
}
var user = { firstName: "Mike", lastName: "Jones" }; // this is fine because age is optional
var userObj = { name: "Alice", age: 33 };
var worker = { firstName: "John", lastName: "Doe", employeeId: 1123 };
var move;
move = "north";
// move = "up"; // error
// Type Guards
function isNumber(value) {
    return typeof value === "number";
}
function printValue(value) {
    if (isNumber(value)) {
        console.log(value.toFixed(2)); // TypeScript knows `value` is a number here
    }
    else {
        console.log(value.toUpperCase()); // TypeScript knows `value` is a string here
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
function identity(arg) {
    return arg;
}
var output1 = identity("Hello");
var output2 = identity(35);
var Box = /** @class */ (function () {
    function Box(field) {
        this.field = field;
    }
    return Box;
}());
// console.log(output1); // Output: Hello
// console.log(output2); // Output: 42
//Array Generics
//Generics can also be used with arrays to ensure type safety.
function getArraySorted(items) {
    return new Array().concat(items);
}
var numArray = getArraySorted([134, 2342, 32, 124]);
var strArray = getArraySorted(["ass", "ber", "casdf"]);
// numArray.push(5); // OK --- did not due in class
// strArray.push("d"); // OK -- did not due in class
console.log(numArray);
console.log(strArray);

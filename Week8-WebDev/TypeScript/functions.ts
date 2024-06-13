//Functions in TS are similar to JS 
// we have the ability now thought o have a typed parameter and return types 

//regular fuction 

function add(x: number, y: number): number {
    return x + y;
}

let sum: number = add(5, 10);
console.log(sum); // Output: 15

//Arrow functions 
//arrow functions provide a more concise syntax and lexically bind the this value

const multiply = (x: number, y: number): number => {
    return x * y;
}

let product: number = multiply(5, 10);
console.log(product); // Output: 50

//Anonymous Funtions 
setTimeout(function() {
    console.log("This is an anonymous function");
}, 1000);

//arrow function 
setTimeout(function() {
    console.log("This is an arrow anonymous function");
}, 1000);


//function overloading 

function concatenate(x: string, y: string): string;
function concatenate(x: number, y: number): number;
function concatenate(x: any, y: any): any {
    return x + y;
}

let stringResult = concatenate("Hello, ", "World!");
let numberResult = concatenate(5, 10);

console.log(stringResult); // Output: Hello, World!
console.log(numberResult); // Output: 15

//Optional and Default parameters
//optional parameters 
//these are specified with a ?
function greet(name: string, greeting?: string): string {
    if (greeting) {
        return `${greeting}, ${name}!`;
    } else {
        return `Hello, ${name}!`;
    }
}

console.log(greet("John")); // Output: Hello, John!
console.log(greet("John", "Good morning")); // Output: Good morning, John!

//Default Parameters 
//defualt parameters provide a way to give a defautl value of nothing elese is given 
function greetDefault(name: string, greeting: string = "Hello"): string {
    return `${greeting}, ${name}!`;
}

console.log(greetDefault("John")); // Output: Hello, John!


//Rest parameters-- this one does not match the example in the guide
//this allows a function to accept an indefinite number of arguments as an array 
function summing(name: string, ...numbers: number[]): string {
    let total = numbers.reduce((total, num)=> total + num, 0);
    return `${name}, your total is ${total} `;
}
 console.log(summing("Mike",3, 4, 5, 6, 7, 8, 10)); 
# JavaScript 1 Guide

JavaScript is a versatile programming language used primarily for web development. This guide will walk you through the basics of JavaScript, covering key features with detailed explanations and examples.

## 1. Datatypes

JavaScript supports several data types:

- **Primitive Types**: `string`, `number`, `boolean`, `null`, `undefined`, `symbol`, `bigint`
- **Reference Types**: `object`, `array`, `function`

### Example:
```javascript
let name = "John";      // string
let age = 30;           // number
let isStudent = false;  // boolean
let car = null;         // null
let address;            // undefined
let uniqueID = Symbol(); // symbol
let largeNumber = 123456789012345678901234567890n; // bigint

let person = {          // object
    name: "John",
    age: 30
};

let hobbies = ["reading", "gaming"]; // array

function greet() {      // function
    console.log("Hello");
}
```

## 2. Type Coercion

JavaScript automatically converts values from one type to another when necessary. This is known as type coercion. It can lead to unexpected results if not handled carefully.

### Example:
```javascript
console.log("5" + 5);   // "55" (string)
console.log("5" - 2);   // 3 (number)
console.log("5" * "2"); // 10 (number)
console.log("five" * 2); // NaN (Not a Number)
```

## 3. Variable Scopes

JavaScript has function scope and block scope:

- **Function Scope**: Variables declared with `var` inside a function are scoped to that function.
- **Block Scope**: Variables declared with `let` or `const` are scoped to the block in which they are defined (e.g., within `{}`).

### Example:
```javascript
function test() {
    var x = 1;          // function scope
    let y = 2;          // block scope
    const z = 3;        // block scope
    {
        let y = 4;      // different block scope
        const z = 5;    // different block scope
        console.log(y); // 4
        console.log(z); // 5
    }
    console.log(y);     // 2
    console.log(z);     // 3
}
test();
```

## 4. Let and Const Keywords

- **let**: Used to declare variables that can be reassigned. They are block-scoped.
- **const**: Used to declare variables that cannot be reassigned. They are also block-scoped.

### Example:
```javascript
let x = 10;
x = 20;     // OK

const y = 10;
y = 20;     // Error: Assignment to constant variable.
```

## 5. Arrays

Arrays are used to store multiple values in a single variable. They provide methods for various operations like adding, removing, and manipulating elements.

### Example:
```javascript
let fruits = ["apple", "banana", "orange"];
console.log(fruits[0]); // "apple"
fruits.push("grape");   // Add an element to the end
console.log(fruits);    // ["apple", "banana", "orange", "grape"]
fruits.pop();           // Remove the last element
console.log(fruits);    // ["apple", "banana", "orange"]
```

## 6. This Keyword

`this` refers to the current context in which a function is executed. Its value depends on how a function is called.

### Example:
```javascript
const person = {
    name: "John",
    greet: function() {
        console.log("Hello, my name is " + this.name);
    }
};
person.greet(); // "Hello, my name is John"

function globalGreet() {
    console.log(this);
}
globalGreet(); // In a browser, `this` refers to the global object (window)
```

## 7. Strict Mode

Strict mode helps you write cleaner code by throwing errors for certain bad practices and disabling some of JavaScript's silent error handling.

### Example:
```javascript
"use strict";
x = 10; // Error: x is not defined
```

## 8. JSON

JSON (JavaScript Object Notation) is a lightweight data interchange format. It is easy for humans to read and write, and easy for machines to parse and generate.

### Example:
```javascript
const jsonString = '{"name": "John", "age": 30}';
const obj = JSON.parse(jsonString); // Parse JSON string to object
console.log(obj.name);              // "John"

const newJsonString = JSON.stringify(obj); // Convert object to JSON string
console.log(newJsonString);         // '{"name":"John","age":30}'
```

## 9. Functions

Functions are blocks of code designed to perform a particular task. They can be defined using the `function` keyword, or as function expressions.

### Example:
```javascript
function greet(name) {
    return "Hello, " + name;
}
console.log(greet("John")); // "Hello, John"

// Function expression
const greetExpression = function(name) {
    return "Hello, " + name;
};
console.log(greetExpression("Jane")); // "Hello, Jane"
```

## 10. Object-Oriented Programming (OOP)

JavaScript supports OOP, which involves using objects and classes to structure your code. Classes are blueprints for creating objects.

### Example:
```javascript
class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    greet() {
        console.log("Hello, my name is " + this.name);
    }
}

const john = new Person("John", 30);
john.greet(); // "Hello, my name is John"
```

## 11. Async Await

`async` and `await` are used to handle asynchronous operations more cleanly than using promises alone. An `async` function returns a promise, and `await` pauses the execution until the promise resolves.

### Example:
```javascript
async function fetchData() {
    try {
        let response = await fetch('https://api.example.com/data');
        let data = await response.json();
        console.log(data);
    } catch (error) {
        console.error("Error fetching data:", error);
    }
}
fetchData();
```

## 12. Arrow Functions

Arrow functions provide a shorter syntax for writing functions and do not bind their own `this`. They are especially useful for inline functions.

### Example:
```javascript
const add = (a, b) => a + b;
console.log(add(2, 3)); // 5

const person = {
    name: "John",
    greet: () => {
        console.log("Hello, my name is " + this.name); // `this` is not bound to `person`
    }
};
person.greet(); // "Hello, my name is undefined"
```

Arrow functions are particularly useful in array methods such as `map`, `filter`, and `reduce`.

### Example:
```javascript
let numbers = [1, 2, 3, 4, 5];
let squaredNumbers = numbers.map(n => n * 2);
console.log(squaredNumbers); // [2, 4, 6, 8, 10]
```

## 13. Truthy Falsy

In JavaScript, values are considered either "truthy" or "falsy." These terms describe how values are evaluated in a Boolean context, such as in conditionals.

### Falsy Values

A falsy value is a value that translates to `false` when evaluated in a Boolean context. The following values are considered falsy in JavaScript:

1. `false`
2. `0`
3. `-0`
4. `0n` (BigInt zero)
5. `""` (empty string)
6. `null`
7. `undefined`
8. `NaN` (Not-a-Number)

### Example

```javascript
if (!false) console.log('Falsy'); // Output: Falsy
if (!0) console.log('Falsy'); // Output: Falsy
if (!-0) console.log('Falsy'); // Output: Falsy
if (!0n) console.log('Falsy'); // Output: Falsy
if (!"") console.log('Falsy'); // Output: Falsy
if (!null) console.log('Falsy'); // Output: Falsy
if (!undefined) console.log('Falsy'); // Output: Falsy
if (!NaN) console.log('Falsy'); // Output: Falsy
```

### Truthy Values

Any value that is not falsy is considered truthy. Truthy values include:

1. `true`
2. Non-zero numbers (e.g., `1`, `-1`, `2`, `3`, etc.)
3. Non-empty strings (e.g., `"hello"`, `"0"`, `"false"`, etc.)
4. Objects (e.g., `{}`, `[]`)
5. `Infinity` and `-Infinity`

### Example

```javascript
if (true) console.log('Truthy'); // Output: Truthy
if (1) console.log('Truthy'); // Output: Truthy
if (-1) console.log('Truthy'); // Output: Truthy
if ("hello") console.log('Truthy'); // Output: Truthy
if ({}) console.log('Truthy'); // Output: Truthy
if ([]) console.log('Truthy'); // Output: Truthy
if (Infinity) console.log('Truthy'); // Output: Truthy
if (-Infinity) console.log('Truthy'); // Output: Truthy
```

## 14. String Interpolation

String interpolation in JavaScript allows you to embed expressions within string literals. This is done using template literals, which are enclosed by backticks (`` ` ``) instead of single or double quotes.

### Syntax

```javascript
`string text ${expression} string text`
```

### Example

```javascript
const name = "John";
const age = 30;
const greeting = `Hello, my name is ${name} and I am ${age} years old.`;

console.log(greeting); // Output: Hello, my name is John and I am 30 years old.
```

### Explanation

- **Template Literals**: Enclosed by backticks (`` ` ``).
- **Expression Embedding**: Expressions are embedded within `${}` and are evaluated and inserted into the string.

### Multiline Strings

Template literals also support multiline strings.

```javascript
const multilineString = `This is a string
that spans multiple
lines.`;

console.log(multilineString);
// Output:
// This is a string
// that spans multiple
// lines.
```

### Example with Functions and Expressions

You can include any valid JavaScript expression inside the `${}`.

```javascript
const a = 5;
const b = 10;

console.log(`The sum of ${a} and ${b} is ${a + b}.`); // Output: The sum of 5 and 10 is 15.

function greet(name) {
    return `Hello, ${name}!`;
}

console.log(`${greet('Alice')}`); // Output: Hello, Alice!
```

JavaScript is a versatile programming language used primarily for web development. This guide will walk you through the basics of JavaScript, covering key features with detailed explanations and examples.

## 1. Datatypes

JavaScript supports several data types:

- **Primitive Types**: `string`, `number`, `boolean`, `null`, `undefined`, `symbol`, `bigint`
- **Reference Types**: `object`, `array`, `function`

### Example:
```javascript
let name = "John";      // string
let age = 30;           // number
let isStudent = false;  // boolean
let car = null;         // null
let address;            // undefined
let uniqueID = Symbol(); // symbol
let largeNumber = 123456789012345678901234567890n; // bigint

let person = {          // object
    name: "John",
    age: 30
};

let hobbies = ["reading", "gaming"]; // array

function greet() {      // function
    console.log("Hello");
}
```

## 2. Type Coercion

JavaScript automatically converts values from one type to another when necessary. This is known as type coercion. It can lead to unexpected results if not handled carefully.

### Example:
```javascript
console.log("5" + 5);   // "55" (string)
console.log("5" - 2);   // 3 (number)
console.log("5" * "2"); // 10 (number)
console.log("five" * 2); // NaN (Not a Number)
```

## 3. Variable Scopes

JavaScript has function scope and block scope:

- **Function Scope**: Variables declared with `var` inside a function are scoped to that function.
- **Block Scope**: Variables declared with `let` or `const` are scoped to the block in which they are defined (e.g., within `{}`).

### Example:
```javascript
function test() {
    var x = 1;          // function scope
    let y = 2;          // block scope
    const z = 3;        // block scope
    {
        let y = 4;      // different block scope
        const z = 5;    // different block scope
        console.log(y); // 4
        console.log(z); // 5
    }
    console.log(y);     // 2
    console.log(z);     // 3
}
test();
```

## 4. Let and Const Keywords

- **let**: Used to declare variables that can be reassigned. They are block-scoped.
- **const**: Used to declare variables that cannot be reassigned. They are also block-scoped.

### Example:
```javascript
let x = 10;
x = 20;     // OK

const y = 10;
y = 20;     // Error: Assignment to constant variable.
```

## 5. Arrays

Arrays are used to store multiple values in a single variable. They provide methods for various operations like adding, removing, and manipulating elements.

### Example:
```javascript
let fruits = ["apple", "banana", "orange"];
console.log(fruits[0]); // "apple"
fruits.push("grape");   // Add an element to the end
console.log(fruits);    // ["apple", "banana", "orange", "grape"]
fruits.pop();           // Remove the last element
console.log(fruits);    // ["apple", "banana", "orange"]
```

## 6. This Keyword

`this` refers to the current context in which a function is executed. Its value depends on how a function is called.

### Example:
```javascript
const person = {
    name: "John",
    greet: function() {
        console.log("Hello, my name is " + this.name);
    }
};
person.greet(); // "Hello, my name is John"

function globalGreet() {
    console.log(this);
}
globalGreet(); // In a browser, `this` refers to the global object (window)
```

## 7. Strict Mode

Strict mode helps you write cleaner code by throwing errors for certain bad practices and disabling some of JavaScript's silent error handling.

### Example:
```javascript
"use strict";
x = 10; // Error: x is not defined
```

## 8. JSON

JSON (JavaScript Object Notation) is a lightweight data interchange format. It is easy for humans to read and write, and easy for machines to parse and generate.

### Example:
```javascript
const jsonString = '{"name": "John", "age": 30}';
const obj = JSON.parse(jsonString); // Parse JSON string to object
console.log(obj.name);              // "John"

const newJsonString = JSON.stringify(obj); // Convert object to JSON string
console.log(newJsonString);         // '{"name":"John","age":30}'
```

## 9. Functions

Functions are blocks of code designed to perform a particular task. They can be defined using the `function` keyword, or as function expressions.

### Example:
```javascript
function greet(name) {
    return "Hello, " + name;
}
console.log(greet("John")); // "Hello, John"

// Function expression
const greetExpression = function(name) {
    return "Hello, " + name;
};
console.log(greetExpression("Jane")); // "Hello, Jane"
```

## 10. Object-Oriented Programming (OOP)

JavaScript supports OOP, which involves using objects and classes to structure your code. Classes are blueprints for creating objects.

### Example:
```javascript
class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    greet() {
        console.log("Hello, my name is " + this.name);
    }
}

const john = new Person("John", 30);
john.greet(); // "Hello, my name is John"
```

## 11. Async Await

`async` and `await` are used to handle asynchronous operations more cleanly than using promises alone. An `async` function returns a promise, and `await` pauses the execution until the promise resolves.

### Example:
```javascript
async function fetchData() {
    try {
        let response = await fetch('https://api.example.com/data');
        let data = await response.json();
        console.log(data);
    } catch (error) {
        console.error("Error fetching data:", error);
    }
}
fetchData();
```

## 12. Arrow Functions

Arrow functions provide a shorter syntax for writing functions and do not bind their own `this`. They are especially useful for inline functions.

### Example:
```javascript
const add = (a, b) => a + b;
console.log(add(2, 3)); // 5

const person = {
    name: "John",
    greet: () => {
        console.log("Hello, my name is " + this.name); // `this` is not bound to `person`
    }
};
person.greet(); // "Hello, my name is undefined"
```

Arrow functions are particularly useful in array methods such as `map`, `filter`, and `reduce`.

### Example:
```javascript
let numbers = [1, 2, 3, 4, 5];
let squaredNumbers = numbers.map(n => n * 2);
console.log(squaredNumbers); // [2, 4, 6, 8, 10]
```
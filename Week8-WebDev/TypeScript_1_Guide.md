# TypeScript Guide - Part 1

## What is TypeScript?

TypeScript is a strongly typed superset of JavaScript that compiles to plain JavaScript. It adds optional static types, classes, and interfaces to help developers write more robust and maintainable code.

## JavaScript vs TypeScript

### JavaScript

- **Dynamic Typing**: Types are determined at runtime.
- **No Type Safety**: Errors can occur if incorrect types are used.
- **Flexible and Weakly Typed**: Easy to write but prone to runtime errors.

### TypeScript

- **Static Typing**: Types are checked at compile-time.
- **Type Safety**: Helps catch errors early.
- **Enhanced Features**: Supports interfaces, enums, and generics.

### Example Comparison

#### JavaScript

```javascript
function greet(name) {
    return "Hello, " + name;
}
console.log(greet(123)); // No error, but might cause issues
```

#### TypeScript

```typescript
function greet(name: string): string {
    return "Hello, " + name;
}
console.log(greet(123)); // Error: Argument of type 'number' is not assignable to parameter of type 'string'
```

## Node.js

Node.js is a JavaScript runtime built on Chrome's V8 JavaScript engine. It allows you to run JavaScript code outside a web browser, making it ideal for server-side and backend development.

To download and install Node.js and npm, follow these steps:

### Step 1: Download Node.js Installer

1. **Visit the Node.js Website**:
   - Go to the [official Node.js website](https://nodejs.org/).

2. **Choose the Right Version**:
   - You will see two versions available for download:
     - **LTS (Long Term Support)**: Recommended for most users, especially for production use.
   - Click the button to download the installer for your operating system (Windows, macOS, or Linux).

### Step 2: Install Node.js and npm

#### On Windows

1. **Run the Installer**:
   - Double-click the downloaded `.msi` file to start the installation process.

2. **Follow the Installation Wizard**:
   - Click "Next" to proceed.
   - Accept the license agreement and click "Next".
   - Choose the installation location and click "Next".
   - Ensure that the "Node.js runtime", "npm package manager", and "Add to PATH" options are checked.
   - Click "Next" and then "Install".

3. **Complete the Installation**:
   - Once the installation is complete, click "Finish".

### Step 3: Verify Installation

1. **Open a Terminal or Command Prompt**:
   - On Windows, open Command Prompt (cmd) or PowerShell.

2. **Check Node.js Version**:
   - Run the following command to check if Node.js is installed correctly:
     ```bash
     node -v
     ```
   - This should output the version of Node.js installed.

3. **Check npm Version**:
   - Run the following command to check if npm is installed correctly:
     ```bash
     npm -v
     ```
   - This should output the version of npm installed.

### Step 4: Verify npm Installation

To ensure that npm has been updated correctly, you can run the version check again:

```bash
npm -v
```

## TypeScript Compiler and Installing TypeScript

### Installing TypeScript

To install TypeScript, you need Node.js and npm (Node Package Manager) installed.

```bash
npm install -g typescript
```

### Compiling TypeScript

TypeScript code is compiled to JavaScript using the TypeScript compiler (`tsc`).

```bash
tsc script.ts
```

## TS Config Basics

The `tsconfig.json` file is used to configure the TypeScript compiler options for a project.

### Example `tsconfig.json`

```json
{
  "compilerOptions": {
    "target": "ES6",
    "module": "commonjs",
    "outDir": "./dist",
    "rootDir": "./src",
    "strict": true
  },
  "include": ["src/**/*"],
  "exclude": ["node_modules"]
}
```

## Compiler Options

### Common Compiler Options

- **target**: Specifies the ECMAScript target version.
- **module**: Specifies the module system.
- **outDir**: Directory for compiled output.
- **rootDir**: Directory containing the TypeScript source files.
- **strict**: Enables all strict type-checking options.

## Simple Types

TypeScript includes basic types such as `string`, `number`, `boolean`, `null`, and `undefined`.

### Example

```typescript
let isDone: boolean = false;
let age: number = 25;
let firstName: string = "John";
let u: undefined = undefined;
let n: null = null;
```

## Arrays

Arrays can hold multiple values of the same type. You can define arrays using two different syntaxes: `type[]` and `Array<type>`.

### Example

```typescript
let list: number[] = [1, 2, 3];
let listGeneric: Array<number> = [1, 2, 3];
```

### Explanation

- **Type[] Syntax**: `number[]` means an array of numbers.
- **Generic Syntax**: `Array<number>` means an array of numbers using generic syntax.

## Tuples

Tuples allow you to define an array with fixed types and length.

### Example

```typescript
let tuple: [string, number];
tuple = ["hello", 10]; // Correct
// tuple = [10, "hello"]; // Error
```

### Explanation

- **Fixed Types**: The first element must be a `string` and the second must be a `number`.

## Enums

Enums allow you to define a set of named constants.

### Example

```typescript
enum Color {
    Red,
    Green,
    Blue
}

let c: Color = Color.Green;
console.log(c); // Output: 1
```

### Explanation

- **Named Constants**: `Red`, `Green`, and `Blue` are named constants with auto-incremented values starting from 0.

## Any

The `any` type allows you to opt-out of type checking.

### Example

```typescript
let notSure: any = 4;
notSure = "maybe a string instead";
notSure = false; // OK
```

### Explanation

- **Flexible Type**: `any` can hold any value, disabling type checks.

## Void

The `void` type is used for functions that do not return a value.

### Example

```typescript
function warnUser(): void {
    console.log("This is my warning message");
}
```

### Explanation

- **No Return Value**: `void` indicates that `warnUser` does not return a value.

## Never

The `never` type represents values that never occur. It is used for functions that always throw an error or never return.

### Example

```typescript
function error(message: string): never {
    throw new Error(message);
}
```

### Explanation

- **No Return**: `never` indicates that `error` will never return a value.

## Functions

# Functions in TypeScript

Functions in TypeScript can be defined with typed parameters and return types, ensuring type safety and reducing runtime errors. In addition to regular functions, TypeScript supports arrow functions and anonymous functions. 

## Regular Functions

### Example

```typescript
function add(x: number, y: number): number {
    return x + y;
}

let sum: number = add(5, 10);
console.log(sum); // Output: 15
```

### Explanation

- **Typed Parameters**: `x` and `y` are declared as `number`.
- **Return Type**: The function is specified to return a `number`.

## Arrow Functions

Arrow functions provide a more concise syntax and lexically bind the `this` value.

### Example

```typescript
const multiply = (x: number, y: number): number => {
    return x * y;
}

let product: number = multiply(5, 10);
console.log(product); // Output: 50
```

### Explanation

- **Syntax**: `(x: number, y: number): number => { ... }`
- **Arrow Function**: More concise and `this` is lexically bound.

## Anonymous Functions

Anonymous functions are functions without a name, often used as arguments to other functions.

### Example

```typescript
setTimeout(function() {
    console.log("This is an anonymous function");
}, 1000);
```

### Arrow Function Example

```typescript
setTimeout(() => {
    console.log("This is an anonymous arrow function");
}, 1000);
```

## Differences Between JavaScript and TypeScript

### JavaScript

JavaScript does not enforce types, making it flexible but prone to runtime errors.

```javascript
function add(x, y) {
    return x + y;
}

let sum = add(5, "10");
console.log(sum); // Output: 510 (string concatenation)
```

### TypeScript

TypeScript enforces types, catching errors at compile-time.

```typescript
function add(x: number, y: number): number {
    return x + y;
}

let sum: number = add(5, 10); // Correct
let wrongSum: number = add(5, "10"); // Error: Argument of type 'string' is not assignable to parameter of type 'number'
```

## Function Overloading

TypeScript supports function overloading, allowing multiple function signatures for a single function.

### Example

```typescript
function concatenate(x: string, y: string): string;
function concatenate(x: number, y: number): number;
function concatenate(x: any, y: any): any {
    return x + y;
}

let stringResult = concatenate("Hello, ", "World!");
let numberResult = concatenate(5, 10);

console.log(stringResult); // Output: Hello, World!
console.log(numberResult); // Output: 15
```

## Optional and Default Parameters

### Optional Parameters

Optional parameters are specified with a `?`.

```typescript
function greet(name: string, greeting?: string): string {
    if (greeting) {
        return `${greeting}, ${name}!`;
    } else {
        return `Hello, ${name}!`;
    }
}

console.log(greet("John")); // Output: Hello, John!
console.log(greet("John", "Good morning")); // Output: Good morning, John!
```

### Default Parameters

Default parameters provide a default value if no value is passed.

```typescript
function greetDefault(name: string, greeting: string = "Hello"): string {
    return `${greeting}, ${name}!`;
}

console.log(greetDefault("John")); // Output: Hello, John!
console.log(greetDefault("John", "Good morning")); // Output: Good morning, John!
```

## Rest Parameters

Rest parameters allow a function to accept an indefinite number of arguments as an array.

### Example

```typescript
function summing(...numbers: number[]): number {
    return numbers.reduce((total, num) => total + num, 0);
}

console.log(summing(1, 2, 3, 4, 5)); // Output: 15
```

## Summary

TypeScript enhances JavaScript functions by adding static types, which helps catch errors at compile-time and improves code readability and maintainability. With support for regular functions, arrow functions, anonymous functions, function overloading, optional and default parameters, and rest parameters, TypeScript provides robust and flexible function capabilities.
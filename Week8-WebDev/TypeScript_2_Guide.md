# TypeScript Guide - Part 2

## Classes

Classes in TypeScript are a blueprint for creating objects with pre-defined properties and methods. TypeScript classes support features like inheritance, access modifiers, and constructors.

### Example

```typescript
class Animal {
    private name: string;

    constructor(name: string) {
        this.name = name;
    }

    public move(distance: number): void {
        console.log(`${this.name} moved ${distance} meters.`);
    }
}

class Dog extends Animal {
    constructor(name: string) {
        super(name);
    }

    public bark(): void {
        console.log('Woof! Woof!');
    }
}

const dog = new Dog('Buddy');
dog.bark(); // Output: Woof! Woof!
dog.move(10); // Output: Buddy moved 10 meters.
```

### Explanation

- **Access Modifiers**: `private`, `protected`, and `public` control the visibility of class members.
- **Inheritance**: The `Dog` class extends the `Animal` class, inheriting its properties and methods.
- **Constructor**: Special method for creating and initializing objects of a class.

## Casting

Casting is used to tell the compiler to treat a variable as a different type.

### Example

```typescript
let someValue: any = "this is a string";
let strLength: number = (someValue as string).length;

console.log(strLength); // Output: 16
```

### Explanation

- **Type Assertion**: `(someValue as string)` tells the TypeScript compiler to treat `someValue` as a `string`.

## Type Aliases and Interfaces

### Type Aliases

Type aliases allow you to create a new name for a type.

### Example

```typescript
type StringOrNumber = string | number;

let value: StringOrNumber;
value = "Hello";
value = 42;
```

### Explanation

- **Union Types**: `string | number` means `value` can be either a `string` or a `number`.

### Interfaces

Interfaces define the structure of an object.

### Example

```typescript
interface Person {
    firstName: string;
    lastName: string;
    age?: number; // Optional property
}

function greet(person: Person): string {
    return `Hello, ${person.firstName} ${person.lastName}`;
}

let user = { firstName: "John", lastName: "Doe" };
console.log(greet(user)); // Output: Hello, John Doe
```

### Explanation

- **Optional Properties**: `age?` means `age` is optional.
- **Function with Interface**: `greet` function expects a `Person` object.

## Object Types

Object types describe the shape of an object, specifying its properties and their types.

### Example

```typescript
let user: { name: string; age: number } = { name: "Alice", age: 25 };

console.log(user.name); // Output: Alice
```

### Explanation

- **Inline Type Declaration**: Defines the structure of the `user` object directly.

## Union Types

Union types allow a variable to be one of several types.

### Example

```typescript
let value: string | number;
value = "Hello"; // OK
value = 42; // OK
// value = true; // Error: Type 'boolean' is not assignable to type 'string | number'
```

### Explanation

- **Multiple Types**: `string | number` allows `value` to be a `string` or a `number`.

## Intersection Types

Intersection types combine multiple types into one.

### Example

```typescript
interface Person {
    name: string;
    age: number;
}

interface Employee {
    employeeId: number;
}

type Worker = Person & Employee;

let worker: Worker = { name: "John", age: 30, employeeId: 12345 };
```

### Explanation

- **Combining Types**: `Person & Employee` means `worker` must have properties from both `Person` and `Employee`.

## Literal Types

Literal types allow you to specify exact values a variable can have.

### Example

```typescript
type Direction = "north" | "south" | "east" | "west";

let move: Direction;
move = "north"; // OK
// move = "up"; // Error: Type '"up"' is not assignable to type 'Direction'
```

### Explanation

- **Exact Values**: `Direction` can only be one of the specified string literals.

## Type Assertions

Type assertions allow you to manually specify a type for a value when you know more about it than TypeScript does.

### Example

```typescript
let someValue: any = "this is a string";
let strLength: number = (someValue as string).length;

console.log(strLength); // Output: 16
```

### Explanation

- **Type Assertion**: `(someValue as string)` tells TypeScript to treat `someValue` as a `string`.

## Type Guards

Type guards allow you to narrow down the type within a conditional block.

### Example

```typescript
function isNumber(value: any): value is number {
    return typeof value === "number";
}

function printValue(value: string | number) {
    if (isNumber(value)) {
        console.log(value.toFixed(2)); // TypeScript knows `value` is a number here
    } else {
        console.log(value.toUpperCase()); // TypeScript knows `value` is a string here
    }
}
```

### Explanation

- **User-Defined Type Guards**: `value is number` tells TypeScript that `value` is a `number` if the function returns `true`.

## Basic Generics

Generics provide a way to create reusable components that work with a variety of types.

### Example

```typescript
function identity<T>(arg: T): T {
    return arg;
}

let output1 = identity<string>("Hello");
let output2 = identity<number>(42);

console.log(output1); // Output: Hello
console.log(output2); // Output: 42
```

### Explanation

- **Generic Function**: `identity<T>(arg: T)` takes a parameter `arg` of type `T` and returns a value of type `T`.
- **Type Parameters**: `<T>` allows the function to be used with different types.

## Array Generics

Generics can also be used with arrays to ensure type safety.

### Example

```typescript
function getArray<T>(items: T[]): T[] {
    return new Array<T>().concat(items);
}

let numArray = getArray<number>([1, 2, 3, 4]);
let strArray = getArray<string>(["a", "b", "c"]);

numArray.push(5); // OK
strArray.push("d"); // OK

console.log(numArray); // Output: [1, 2, 3, 4, 5]
console.log(strArray); // Output: ["a", "b", "c", "d"]
```

### Explanation

- **Generic Array Function**: `getArray<T>(items: T[]): T[]` ensures that `items` is an array of type `T` and returns an array of the same type.
- **Type Safety**: `numArray` and `strArray` are type-checked to only allow `number` and `string` types, respectively.
# TypeScript

Typescript is a superset of Javascript. This means that any valid JavaScript is valid Typescript, and in order to run any typescript, you need to transpile it into JavaScript.

This is done through the TypeScript Compiler, `tsc`.

Whenever we write any TypeScript files, we have to use the compiler in order to create JavaScript files.

We can choose the specific version of JavaScript that we want to transpile the typescript into. We have a lot of flexibility with how we can use TypeScript which helps when working with different browsers.


## Why?

TypeScript introduces types, and some form of data type validation to many features of JavaScript like function parameters, return types, and just variable declarations. 

There is also more support for OOP features, like inheritance, access modifiers, and interfaces. These features are built off of what JS has, but makes our lives easier as developers.

JavaScript is designed for smaller applications, and smaller scripts. It is a scripting language, which means the code you write is read, compiled, and executed line by line. This is different to compiled languages like C# or Java, where the entire file is first read, then the entire file is compiled, and then it is executed. 

However, as JavaScript became the dominant language in the web development field, it began to be used in larger and larger applications. This meant development with the language designed for small applications, were used in areas that it is not good in. Essentially, this is where TypeScript in.

For larger applications, features like type safety, type inference, and IDE support is really helpful. Not having to guess the parameter data type when calling a function, or having to check if the function does return something in order to use it, really speeds up your coding speed. You also have to deal with less phantom bugs, bugs where the code compiles and it runs, but it doesn't work the way you intend and so you need to sift through your script to find that error.
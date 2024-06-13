//Functions in TS are similar to JS 
// we have the ability now thought o have a typed parameter and return types 
//regular fuction 
function add(x, y) {
    return x + y;
}
var sum = add(5, 10);
console.log(sum); // Output: 15
//Arrow functions 
//arrow functions provide a more concise syntax and lexically bind the this value
var multiply = function (x, y) {
    return x * y;
};
var product = multiply(5, 10);
console.log(product); // Output: 50
//Anonymous Funtions 
setTimeout(function () {
    console.log("This is an anonymous function");
}, 1000);
//arrow function 
setTimeout(function () {
    console.log("This is an arrow anonymous function");
}, 1000);
function concatenate(x, y) {
    return x + y;
}
var stringResult = concatenate("Hello, ", "World!");
var numberResult = concatenate(5, 10);
console.log(stringResult); // Output: Hello, World!
console.log(numberResult); // Output: 15
//Optional and Default parameters
//optional parameters 
//these are specified with a ?
function greet(name, greeting) {
    if (greeting) {
        return "".concat(greeting, ", ").concat(name, "!");
    }
    else {
        return "Hello, ".concat(name, "!");
    }
}
console.log(greet("John")); // Output: Hello, John!
console.log(greet("John", "Good morning")); // Output: Good morning, John!
//Default Parameters 
//defualt parameters provide a way to give a defautl value of nothing elese is given 
function greetDefault(name, greeting) {
    if (greeting === void 0) { greeting = "Hello"; }
    return "".concat(greeting, ", ").concat(name, "!");
}
console.log(greetDefault("John")); // Output: Hello, John!
//Rest parameters-- this one does not match the example in the guide
//this allows a function to accept an indefinite number of arguments as an array 
function summing(name) {
    var numbers = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        numbers[_i - 1] = arguments[_i];
    }
    var total = numbers.reduce(function (total, num) { return total + num; }, 0);
    return "".concat(name, ", your total is ").concat(total, " ");
}
console.log(summing("Mike", 3, 4, 5, 6, 7, 8, 10));

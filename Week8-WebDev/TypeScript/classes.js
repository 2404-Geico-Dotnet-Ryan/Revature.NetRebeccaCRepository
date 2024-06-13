//clssses 
/*
Classes in TS are a blueprint
TS class support things like:
    Inheritance
    Access Modifiers
    Constructors
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
// key word is extend
// super here is the "base" in C#
var Dog = /** @class */ (function (_super) {
    __extends(Dog, _super);
    function Dog(name) {
        return _super.call(this, name) || this;
    }
    Dog.prototype.bark = function () {
        console.log('Woof! Woof!');
    };
    return Dog;
}(Animal));
var dog = new Dog('Buddy');
dog.bark(); // Output: Woof! Woof!
dog.move(10); // Output: Buddy moved 10 meters.
//Casting 
// let someValue: any = "this is a string";
// let strLength: number = (someValue as string).length;
// console.log(strLength); // Output: 16
// const dog = new Dog('Buddy');
// dog.bark(); // Output: Woof! Woof!
// dog.move(10); // Output: Buddy moved 10 meters.

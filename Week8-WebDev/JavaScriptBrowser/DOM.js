//Document Object Model
/*
    This acts as an object representation of the HTML document so that we can programmatically interact with the webpage

    This is essentially an interface that lets us use interact, manipulate, remove, or add things to the document structure, style, and content.
    The DOM 
*/
console.log(document);

//Element Selectors 
/*
    In order to manipulate the DOM, you need to be able ot select items from the DOM. 
    There several methods, some follow a new syntax, others follow the CSS syntax
*/
//Select by ID 
const header = document.getElementById('header');
console.log(header);

//Select by Class Name

const intro = document.getElementsByClassName('intro');
console.log(intro);

//Select by Tag Name 
const paragraphs = document.getElementsByTagName('p');
console.log(paragraphs);

//select by CSS Selectors
// We are using the css syntax for selecting content as the id is content so we use #content
//if we were trying to select a class, it would be .intro
const content = document.querySelector('#content');
const allParagraphs = document.querySelectorAll('p');


//DOM Manipulation 
//Once we have selected an element, you can manipulate 

//change content
header.textContent= 'Hello World!' //this overwrites the index header that was there

//change styles this particular one - this will not display the color picker but you can look it up on the web by css color picker and copy codes into here
header.style.color = 'blue';

//add a new class 
header.classList.add('highlight');

//remove an element
const button = document.getElementById('myButton');
button.remove();

//add elements and append elements
const newButton = document.createElement('button');
newButton.textContent = "New Button!";
document.body.appendChild(newButton);

//Traversing the DOM
//DOM traversal allows you to navigate between elements in the DOM tree.

const contentDiv = document.getElementById('content');

// Parent node
const parent = contentDiv.parentNode;
const parentElements = contentDiv.parentElement;//if I just want the elements
console.log(parent);
console.log(parentElements);

// Child nodes
const children = contentDiv.childNodes;
const childrenElements = contentDiv.children; //if I just want the elements
console.log(children);
console.log(childrenElements);

// This removes every other entry when should be every entry
// for(const paragraph of childrenElements)
//     {
//         paragraph.remove();
//     }

//Could not get this to work
// for(let i =childrenElements.Length -1; i>=0; i--)
//     {
//         childrenElements[i].remove();
//     }

//this remove works******************************************
// while(contentDiv.firstChild) 
//     {
//         contentDiv.removeChild(contentDiv.firstChild);
//     }

// NEED to see if can make this work ********************************
// const paragraph1=childrenElements[0];
// const parentParagraphNode =paragraph1.parentNode;
// const parentParagraph1Element=paragraph1.parentElement;

// console.log(parentParagraphNode);
// console.log(parentParagraphElement);

// First child
const firstChild = contentDiv.firstChild;

// Last child
const lastChild = contentDiv.lastChild;

// Sibling nodes
const nextSibling = contentDiv.nextSibling;
const previousSibling = contentDiv.previousSibling;

//Events and Listeners
//JavaScript can respond to user interactions by listening for events and executing functions when those events occur.
//search js Dom events w3 schools defines events- like buttons or https://developer.mozilla.org/en-US/docs/Web/Events
/*
Because I am getting elements by tag name this will be default 
return an arrayof elements even if there is only one
because of that I will use the [0] to grab the first element from that collection

*/
// Select the button before you start the events/listeners
const newButtonSelected = document.getElementsByTagName('button')[0];
console.log(newButtonSelected); //this is sanity checking to make sure we are choosing the right one

// Define a function to run when the button is clicked-- this will create a pop up box when the button is clicked 
function handleClick() 
    {
        alert('Button was clicked!');
    }

// Add an event listener to the button

//the syntax of the addEventListener is the ('event_name', function name)
newButtonSelected.addEventListener('click', handleClick);

/*
Event propagation in the DOM has two main phases: capturing and bubbling.

- **Capturing**: The event starts from the root and propagates down to the target element.
- **Bubbling**: The event starts from the target element and propagates up to the root.

You can specify the phase in which to handle the event by adding a third parameter to `addEventListener`.
*/
document.body.addEventListener('click', function() {
    console.log('Body clicked (capturing)');
}, true);

// Bubbling phase
document.body.addEventListener('click', function() {
    console.log('Body clicked (bubbling)');
}, false);



//Fetch API 
//The Fetch API provides a way to make network requests similar to `XMLHttpRequest`. It is more powerful and flexible. and it works with JSON and all the HTTP methods
//You want the user to be able to continue to work with the website while waiting on replies (a synchronically)
/*
    we want to get data from an api
    in order to get that data we need the following 
        URL
        HTTP Method
        if sending data, you need to turn your JavaScript object into JSON

    once we get some kind of response
        check if the response is okay
        if there is JSON, turn it into a JavaScript object

    we are going to interact wtih the poke API 
    the url is: https://pokeapi.co/api/v2/pokemon/1
*/
//promises approach
//fetch will by default this is a get method
/*
    when you create a promise there are 3 states that it can exist in 
        not started == before anything (this is actually a 4th that we are not interested in )
        pending == this is in the process of being completed 
        completed successfully = then
        completed unsuccessfully = catch

    this is an asynchronis try catch (runs at same time while other things are happening)
*/

// we initiate the fetch request, and by default it will a GET method
fetch('https://pokeapi.co/api/v2/pokemon/1')
    .then(response => response.json())   // this part is similar to how parse works in c# -when we get back the response we turn it into JavaScript object
    .then(data => {
        console.log(data); //once this is complete we print it to the console
    })
    .catch(error => {
        console.error('Error:', error);// if at any point something goes wrong, we print this error to the console
    });



// Using async/await for fetching data - most developers prefer this method vs the promises
//this is essentially same as above 
async function fetchData() 
    {
        try {
                let response = await fetch('https://pokeapi.co/api/v2/pokemon/1');// the word await pause the code until response is completed but is still asynchronis as it is inside the same function 

                let data = await response.json();
                console.log(data);
            } 
        catch (error) 
            {
                console.error('Error:', error);
            }
    }
    fetchData();
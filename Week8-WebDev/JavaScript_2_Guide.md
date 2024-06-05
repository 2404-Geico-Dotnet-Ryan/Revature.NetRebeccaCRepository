# JavaScript 2 Guide

JavaScript is a powerful tool for manipulating and interacting with the Document Object Model (DOM) of a web page. This guide will walk you through key concepts related to the DOM and how to use JavaScript to interact with it.

## 1. DOM Structure

The DOM is a programming interface for web documents. It represents the page so that programs can change the document structure, style, and content. The DOM is a tree-like structure where each node represents an element or a piece of content in the document.

### Example:
```html
<!DOCTYPE html>
<html>
<head>
    <title>My Webpage</title>
</head>
<body>
    <h1 id="header">Welcome to My Webpage</h1>
    <p class="intro">This is an introductory paragraph.</p>
    <div id="content">
        <p>Content goes here...</p>
    </div>
    <button id="myButton">Click me</button>
    <script src="script.js"></script>
</body>
</html>
```

## 2. Selecting Elements from a WebPage

To manipulate the DOM, you first need to select the elements you want to work with. JavaScript provides several methods for selecting elements.

### Example:
```javascript
// Select by ID
const header = document.getElementById('header');

// Select by class name
const intro = document.getElementsByClassName('intro');

// Select by tag name
const paragraphs = document.getElementsByTagName('p');

// Select using CSS selectors
const content = document.querySelector('#content');
const allParagraphs = document.querySelectorAll('p');
```

## 3. DOM Manipulation

Once you have selected an element, you can manipulate it by changing its properties, attributes, and content.

### Example:
```javascript
// Change content
header.textContent = 'Hello, World!';

// Change style
header.style.color = 'blue';

// Add a new class
header.classList.add('highlight');

// Remove an element
const button = document.getElementById('myButton');
button.remove();

// Create and append a new element
const newParagraph = document.createElement('p');
newParagraph.textContent = 'This is a new paragraph.';
document.body.appendChild(newParagraph);
```

## 4. Traversing the DOM

DOM traversal allows you to navigate between elements in the DOM tree.

### Example:
```javascript
const contentDiv = document.getElementById('content');

// Parent node
const parent = contentDiv.parentNode;

// Child nodes
const children = contentDiv.childNodes;

// First child
const firstChild = contentDiv.firstChild;

// Last child
const lastChild = contentDiv.lastChild;

// Sibling nodes
const nextSibling = contentDiv.nextSibling;
const previousSibling = contentDiv.previousSibling;
```

## 5. Events and Listeners

JavaScript can respond to user interactions by listening for events and executing functions when those events occur.

### Example:
```javascript
// Select the button
const button = document.getElementById('myButton');

// Define a function to run when the button is clicked
function handleClick() {
    alert('Button was clicked!');
}

// Add an event listener to the button
button.addEventListener('click', handleClick);
```

## 6. Bubbling and Capturing

Event propagation in the DOM has two main phases: capturing and bubbling.

- **Capturing**: The event starts from the root and propagates down to the target element.
- **Bubbling**: The event starts from the target element and propagates up to the root.

You can specify the phase in which to handle the event by adding a third parameter to `addEventListener`.

### Example:
```javascript
// Capturing phase
document.body.addEventListener('click', function() {
    console.log('Body clicked (capturing)');
}, true);

// Bubbling phase
document.body.addEventListener('click', function() {
    console.log('Body clicked (bubbling)');
}, false);
```

## 7. Fetch API

The Fetch API provides a way to make network requests similar to `XMLHttpRequest`. It is more powerful and flexible.

### Example:
```javascript
// Fetch data from an API
fetch('https://api.example.com/data')
    .then(response => response.json())
    .then(data => {
        console.log(data);
    })
    .catch(error => {
        console.error('Error:', error);
    });

// Using async/await for fetching data
async function fetchData() {
    try {
        let response = await fetch('https://api.example.com/data');
        let data = await response.json();
        console.log(data);
    } catch (error) {
        console.error('Error:', error);
    }
}

fetchData();
```
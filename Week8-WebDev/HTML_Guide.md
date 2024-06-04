# HTML Learning Guide

HTML (Hypertext Markup Language) is the standard language for creating web pages and web applications. This guide will walk you through the basics of HTML, covering key features with examples to illustrate each concept. We will use a simple example of creating a personal profile webpage to demonstrate different HTML features.

## 1. HTML Tags

HTML tags are the building blocks of HTML. They are used to define elements on a webpage. Tags are enclosed in angle brackets `< >` and usually come in pairs: an opening tag `<tag>` and a closing tag `</tag>`.

Example:
```html
<!DOCTYPE html>
<html>
<head>
    <title>My Profile</title>
</head>
<body>
    <h1>Welcome to My Profile</h1>
</body>
</html>
```

## 2. HTML Documents

An HTML document is a file containing HTML code and has an `.html` extension. It consists of several key components:

- `<!DOCTYPE html>`: Declares the document type and version of HTML.
- `<html>`: The root element of an HTML document.
- `<head>`: Contains meta-information about the document (title, character set, styles, scripts, etc.).
- `<body>`: Contains the content of the document.

Example:
```html
<!DOCTYPE html>
<html>
<head>
    <title>My Profile</title>
</head>
<body>
    <h1>Welcome to My Profile</h1>
</body>
</html>
```

## 3. Elements and Attributes

HTML elements are the basic building blocks of a webpage. An element consists of a start tag, content, and an end tag. Attributes provide additional information about elements and are included within the start tag.

Example:
```html
<p class="intro">Hello! My name is John Doe.</p>
```

In this example, `<p>` is the element, `class` is an attribute, and `"intro"` is the attribute value.

## 4. Inline and Block Elements

HTML elements can be either inline or block elements:

- **Inline elements** do not start on a new line and only take up as much width as necessary. Examples include `<span>`, `<a>`, `<img>`.
- **Block elements** start on a new line and take up the full width available. Examples include `<div>`, `<h1> - <h6>`, `<p>`.

Example:
```html
<p>This is a block element.</p>
<span>This is an inline element.</span>
```

## 5. Common Tags

Here are some commonly used HTML tags:

- `<h1> - <h6>`: Headings
- `<p>`: Paragraph
- `<a>`: Anchor (link)
- `<img>`: Image
- `<ul>`, `<ol>`, `<li>`: Lists
- `<div>`: Division (block container)
- `<span>`: Span (inline container)

Example:
```html
<h1>John Doe</h1>
<p>Hello! My name is John Doe, and I am a web developer.</p>
<a href="https://example.com">Visit my website</a>
<img src="profile.jpg" alt="Profile Picture">
```

## 6. Input Elements and Forms

Forms are used to collect user input. The `<form>` element wraps the input elements, and various `<input>` types are used to create different types of form fields.

Example:
```html
<form action="/submit-profile" method="post">
    <label for="name">Name:</label>
    <input type="text" id="name" name="name">
    
    <label for="email">Email:</label>
    <input type="email" id="email" name="email">
    
    <input type="submit" value="Submit">
</form>
```

## 7. Select and Multi-selects

The `<select>` element is used to create a drop-down list. The `multiple` attribute can be added to allow multiple selections.

Example:
```html
<form action="/submit-profile" method="post">
    <label for="hobbies">Choose your hobbies:</label>
    <select id="hobbies" name="hobbies" multiple>
        <option value="coding">Coding</option>
        <option value="reading">Reading</option>
        <option value="gaming">Gaming</option>
        <option value="traveling">Traveling</option>
    </select>
    
    <input type="submit" value="Submit">
</form>
```

## Complete Example

Here is the complete HTML code with all the features we've discussed:

```html
<!DOCTYPE html>
<html>
<head>
    <title>My Profile</title>
</head>
<body>
    <h1>Welcome to My Profile</h1>
    <p class="intro">Hello! My name is John Doe, and I am a web developer.</p>
    <a href="https://example.com">Visit my website</a>
    <img src="profile.jpg" alt="Profile Picture">
    
    <form action="/submit-profile" method="post">
        <label for="name">Name:</label>
        <input type="text" id="name" name="name">
        
        <label for="email">Email:</label>
        <input type="email" id="email" name="email">
        
        <label for="hobbies">Choose your hobbies:</label>
        <select id="hobbies" name="hobbies" multiple>
            <option value="coding">Coding</option>
            <option value="reading">Reading</option>
            <option value="gaming">Gaming</option>
            <option value="traveling">Traveling</option>
        </select>
        
        <input type="submit" value="Submit">
    </form>
</body>
</html>
```

You can copy this code into an HTML file (`profile.html`) and open it in a web browser to see the complete example in action.
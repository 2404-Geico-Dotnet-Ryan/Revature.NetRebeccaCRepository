# CSS Learning Guide

CSS (Cascading Style Sheets) is used to control the presentation and layout of web pages. This guide will walk you through the basics of CSS, covering key features with examples to illustrate each concept. We will use a simple example of styling a personal profile webpage to demonstrate different CSS features.

## 1. Inline, Internal, and External CSS

CSS can be applied to HTML in three ways:

- **Inline CSS**: Applied directly within an HTML element using the `style` attribute.
- **Internal CSS**: Placed within a `<style>` tag in the HTML document's `<head>` section.
- **External CSS**: Defined in an external file with a `.css` extension and linked to the HTML document using the `<link>` tag.

### Inline CSS

Example:
```html
<p style="color: blue; font-size: 20px;">Hello! My name is John Doe.</p>
```

### Internal CSS

Example:
```html
<!DOCTYPE html>
<html>
<head>
    <title>My Profile</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .intro {
            color: blue;
            font-size: 20px;
        }
    </style>
</head>
<body>
    <p class="intro">Hello! My name is John Doe.</p>
</body>
</html>
```

### External CSS

Create an external CSS file named `styles.css`:
```css
body {
    font-family: Arial, sans-serif;
}
.intro {
    color: blue;
    font-size: 20px;
}
```

Link the external CSS file in your HTML document:
```html
<!DOCTYPE html>
<html>
<head>
    <title>My Profile</title>
    <link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
    <p class="intro">Hello! My name is John Doe.</p>
</body>
</html>
```

## 2. CSS Properties

CSS properties define the styles for HTML elements. Each property has a name and a value, separated by a colon, and multiple properties are separated by semicolons.

Example:
```css
.intro {
    color: blue;
    font-size: 20px;
    margin: 10px;
}
```

## 3. Element Selectors

Element selectors target HTML elements directly by their tag name.

Example:
```css
p {
    color: green;
}
```

This CSS rule will style all `<p>` elements in green.

## 4. Class and ID Selectors

- **Class Selector**: Targets elements with a specific class attribute. Classes are defined with a period (`.`) followed by the class name.
- **ID Selector**: Targets a specific element with an ID attribute. IDs are defined with a hash (`#`) followed by the ID name.

### Class Selector

Example:
```css
.intro {
    color: blue;
    font-size: 20px;
}
```

### ID Selector

Example:
```css
#main-header {
    font-size: 24px;
    font-weight: bold;
}
```

HTML:
```html
<h1 id="main-header">Welcome to My Profile</h1>
```

## 5. CSS Box Model

The CSS Box Model describes the rectangular boxes that are generated for elements in the document tree. It consists of margins, borders, padding, and the actual content.

Example:
```css
.box {
    width: 300px;
    padding: 20px;
    border: 5px solid black;
    margin: 10px;
}
```

HTML:
```html
<div class="box">
    This is a box with padding, border, and margin.
</div>
```

## Complete Example

Here is the complete HTML and CSS code incorporating all the features we've discussed:

### HTML (`profile.html`)

```html
<!DOCTYPE html>
<html>
<head>
    <title>My Profile</title>
    <link rel="stylesheet" type="text/css" href="styles.css">
    <style>
        #main-header {
            font-size: 24px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <h1 id="main-header">Welcome to My Profile</h1>
    <p class="intro">Hello! My name is John Doe, and I am a web developer.</p>
    <a href="https://example.com">Visit my website</a>
    <img src="profile.jpg" alt="Profile Picture">
    
    <div class="box">
        This is a box with padding, border, and margin.
    </div>
    
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

### External CSS (`styles.css`)

```css
body {
    font-family: Arial, sans-serif;
}

.intro {
    color: blue;
    font-size: 20px;
}

a {
    color: red;
    text-decoration: none;
}

a:hover {
    text-decoration: underline;
}

.box {
    width: 300px;
    padding: 20px;
    border: 5px solid black;
    margin: 10px;
}
```

You can copy the HTML code into a file named `profile.html` and the CSS code into a file named `styles.css`. Open `profile.html` in a web browser to see the complete example in action.
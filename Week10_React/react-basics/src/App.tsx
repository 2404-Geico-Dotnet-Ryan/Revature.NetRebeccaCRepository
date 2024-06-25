import React from 'react';
import './App.css';
import ComponentOne from './components/ComponentOne/ComponentOne';
import ComponentTwo from './components/ComponentTwo/ComponentTwo';
import EventsDemo from './components/EventsDemo/EventsDemo';
import ListDemo from './components/ListDemo/ListDemo';
import ParentComponent from './components/Props/ParentComponent/ParentComponent';
import { Route, Routes } from 'react-router-dom';
import NavBar from './components/NavBar/NavBar';
import Hooks from './components/Hooks/Hooks';
import Refs from './components/Refs/Refs';
/*
  We work with Functional Components for the most part in React, although there are Class Components.

  The reason why we use Functional Components over class components is because of two reasons, FCs are being pushed by React and so a lot of the features with React are built around it. It is also faster and more efficient than Class Components.


  What is a Component?
    - Snippet of HTML, CSS, and JS (TS)
    - Building blocks for the HTML page
    - Two types
        - Functional
        - Class

    We cannot have both, as they are essentially equivalent but implemented quite differently.
    In the long run we need to learn both, but for now the focus is on functional components.
*/

// class App extends React.Component {
//   render(): React.ReactNode {
//     return (
//       <div className="App">
//         <h1>Hello!</h1>
//       </div>
//     )
//   }
// }

function App() : React.JSX.Element {
  // The body of the function
  // In here, you will do all of your logic regarding the component
  return (
    // This return statement, contains the body of the component
    // And what will be displayed to the page

    /*
      Whatever we return, it has to be a root element. Meaning, you cannot have any siblings inside the return, they have to be nested inside a parent.
    */
    <div className="App">
        {/* <ComponentTwo/>
        <ComponentOne/>
        <ComponentTwo/>
        <EventsDemo/>
        <ListDemo/>
        <ParentComponent/> */}
        {/* 
        
          Routes is a specific component that will check the URL of the webpage to decide what component to display

          If you wanted a component to show all throughout your application, no matter what page or path they are on then you would put it in the App.tsx next to the Routes.
        */}
        <NavBar/>
        <Routes>
          <Route path="/" element={<ComponentOne/>}></Route>
          <Route path="/events" element={<EventsDemo/>}></Route>
          <Route path="/lists" element={<ListDemo/>}></Route>
          <Route path="/props" element={<ParentComponent/>}></Route>
          <Route path="/hooks" element={<Hooks/>}></Route>
          <Route path="/refs" element={<Refs/>}></Route>
        </Routes>
    </div>
  );
}

export default App;
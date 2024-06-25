import React from 'react';
import logo from './logo.svg';
import './App.css';
import Counter from './Components/Counter/Counter';
import Greeting from './Components/GreetingComponent/Greeting';
import Async from './Components/AsyncComponent/Async';

function App() {
  return (
    <div className="App">
      <Counter/>
      <Greeting/>
      <Async/>      
    </div>
  );
}

export default App;

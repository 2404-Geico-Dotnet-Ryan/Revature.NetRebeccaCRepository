import React from 'react';
import { Route, Routes } from 'react-basics-router-dom';
import logo from './logo.svg';
import './App.css';
import ComponentOne from './components/ComponentOne/ComponentOne';
import NavBar from './NavBar/NavBar';
import StatefulComponent from './components/StatefulComponent/StatefulComponent';
 


function App(): React.JSX.Element {
  return (
    <div className="App">
      <NavBar/>
      <Routes>
          <Route path="/" element={<ComponentOne/>}></Route>
          <Route path="/events" element={<Events/>}></Route>
          <Route path="/lists" element={<Lists/>}></Route>
          <Route path="/statefulComponent" element={<StatefulComponent/>}></Route>
          
      </Routes>
    </div>
  );
}

export default App;

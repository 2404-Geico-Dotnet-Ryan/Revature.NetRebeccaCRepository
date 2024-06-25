import React, { useState } from 'react';
import './App.css';
import ComponentOne from './Components/ComponentOne';
import Events from './Events/Events';
import {Route, Routes} from 'react-router-dom';
import NavBar from './NavBar/NavBar';
import List from './List/List';
import ListsAndKeysComponent from './Props/ListAndKeysComponent/ListsAndKeysComponent';
import ProductComponent from './Props/ProductComponent/ProductComponent';
import { User } from './model/User';
import { UserContext } from './Context/context';



function App() : React.JSX.Element {
  const [user, setUser] = useState<User | undefined>({
    userId: 1,
    username: 'user1',
    password: 'pass1',
    email: 'user1@email.com',
    isAdmin: true
  });
 
  return (
    <div className="App">
      <UserContext.Provider value={user}>
        <ListsAndKeysComponent/>
      </UserContext.Provider>
    </div>
  );

  return (  
    <div className="App">
        <NavBar/>
        <Routes>
          <Route path="/" element={<ComponentOne/>}></Route>
          <Route path="/events" element={<Events/>}></Route>
          <Route path="/list" element={<List/>}></Route>
          <Route path="/listandkeycomponents" element={<ListsAndKeysComponent/>}></Route>
          <Route path="/productcomponent" element={<ProductComponent key={0} product={undefined}/>}></Route>

        </Routes>
    </div>
  );
}

export default App;
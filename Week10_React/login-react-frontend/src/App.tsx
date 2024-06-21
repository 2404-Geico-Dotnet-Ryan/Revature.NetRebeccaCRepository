import React, { useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import LoginComponent, { User } from './Components/LoginComponent/LoginComponent';
import { UserContext } from './context/userContext';
import UserProfileComponent from './Components/UserProfileComponent/UserProfileComponent';




function App() {
  /*
    By using UserContext.Provider, anything inside of it can reference the user with useContext anywhere without having to provide it with props

  */
  const [user, setUser] = useState<User | undefined>(undefined);

  return (
    <div className="App">
      <UserContext.Provider value={user}>
        <UserProfileComponent/>
        <Routes>
          <Route path="/" element={<LoginComponent setUser={setUser}/>}/>
        </Routes>
      </UserContext.Provider>
    </div>
  );
}

export default App;

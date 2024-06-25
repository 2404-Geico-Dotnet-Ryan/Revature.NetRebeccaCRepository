import React, { useState } from 'react'
 
function Greeting() {
    const [changedText, setChangedText] = useState(false);
   
    function changeTextHandler(){
        setChangedText(true);
    }
 
  return (
    <div>
        <h2>Hello World</h2>
        {!changedText && <p>It's nice to meet you</p>}
        {changedText && <p>I have been changed</p>}
        <button onClick={changeTextHandler}>Change Text!</button>
    </div>
  )
}
 
export default Greeting
import React, { useEffect, useRef, useState } from 'react'

/*
add comments from Brain work
*/
function Refs() {

  const[count, setCount]= useState(0);
  const prevCountRef = useRef(0);

  useEffect(()=>{
    prevCountRef.current=count;
  }, [count])
  const prevCount = prevCountRef.current;
  
  const inputRef = useRef(null);
  
  function focusInput(){
    inputRef.current.focus();
  }

  function blurInput(){
    inputRef.current.blur();
  }
  return (
    <div>

        <input ref = {inputRef} type ="text"></input>

    </div>
  )
}

export default Refs
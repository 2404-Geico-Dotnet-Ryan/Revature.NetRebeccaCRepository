import React, { useEffect, useRef, useState } from 'react'

/*
    Refs provide a way to access DOM nodes or React elements created in the render method
    They are useful when you need to interact directly with a DOM element
    For example, focusing an input, manage animations, or integrating third party libraries

    Creating a Ref
    we use the hook useRef() to create a ref
*/

function Refs() {

    const [count, setCount] = useState(0);
    const prevCountRef= useRef(0);

    useEffect(() => {
        prevCountRef.current = count;
    }, [count]);

    const prevCount = prevCountRef.current;


    function increment(){
        setCount(count + 1);
    }

    const inputRef: any = useRef(null);

    function focusInput(){
        inputRef.current.focus();
    }

    function blurInput(){
        inputRef.current.blur();
    }

  return (
    <div>
        {/* We assing a ref to the element that we want to have a direct reference to its DOM node */}
        <input onMouseEnter={focusInput} onMouseLeave={blurInput} ref={inputRef} type="text"></input>

        <h1>Current Count: {count}</h1>
        <h2>Previous Count: {prevCount}</h2>
        <button onClick={increment}>Increment</button>
    </div>
  )
}

export default Refs
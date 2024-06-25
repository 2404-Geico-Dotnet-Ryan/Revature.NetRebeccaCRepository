import React from 'react'

function Events() {

    function handleClick(){
        console.log("Click!");
    }

    function handleChangeInput(event: any){
        console.log(event.target.value);
    }

  return (
    <>
        <input 
            onClick={() => console.log("click")}
            type="button" 
            value="Click Me"
        />
        <input
            type="text"
            onChange={(event: any) => console.log(event.target.value)}
        />
    </>
  )
}

export default Events
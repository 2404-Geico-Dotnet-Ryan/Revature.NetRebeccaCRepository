import React from 'react'

function EventsDemo() {

    function clickEventTriggered(){
        console.log("Click button triggered");
    }

    function hoverEventTriggered(){
        console.log("Hover event triggered")
    }
    /*
        Traditionally, if we wanted to see the value of the input we would have had to use the DOM selector and reference the .value property

        However, we do not have access to the DOM, React does. And so, we need to access the properties through the function as an event parameter.

        We set the type of this event to be any, as the actual type is hyper specific and does not greatly improve your QoL
    */
    function inputChanged(event: any){
        // console.log("Input has changed");
        console.log(event.target.value);
    }

  return (
    <div>
        <button onClick={clickEventTriggered}>Click Event</button>
        <button onMouseOver={hoverEventTriggered}>Hover Event</button>
        <input type="text" placeholder="Username" onChange={inputChanged}/>
    </div>
  )
}

export default EventsDemo
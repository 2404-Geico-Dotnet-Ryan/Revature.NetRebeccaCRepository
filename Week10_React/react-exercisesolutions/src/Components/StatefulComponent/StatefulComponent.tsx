import React, { useState } from 'react'

function StatefulComponent() {

    const [state, setState] = useState<any>({
        count: 0,
        currentText: ''
    });

    function addThingToState(){
        setState({...state, count: state.count + 1});
    }

    function updateText(event: any){
        setState({...state, currentText: event.target.value})
    }
  return (
    <div>
        <h1>{state.count}</h1>
        <h2>{state.currentText}</h2>
        <button onClick={addThingToState}>This is a button</button>
        <input onChange={updateText} type="text"></input>
    </div>
  )
}

export default StatefulComponent
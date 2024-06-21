import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Pokemon } from './Poleman';


/*
    Components have lifecycle methods that can be grouped together as such:

        - Initialization
            - Where the component is initially created in code, and any initial values are setup
            - props or state values
        - Mounting
            - Where the component in the React Virtual DOM is actually added and rendered to the actual DOM
        - Updation
            - Where if there are any updates to the component that need to be shown to the screen
            - Example, if someone were to change a field or name, it should reflect everywhere else
            - If a number is meant to go up and display to the screen, it should
            - This is based on if the Prop or the State of the component changes
            - State refers to any value or field in the component that when changed, will trigger a re-render
        - UnMounting
            - This is when a component is removed from the DOM and the Virtual DOM
        
        All of these stages have methods that we can intercept and override or add additional behaviors


    What is a hook?
        - Extra methods added to functional components to replicate the behavior of class components
    
    Hooks we will be using
        - useState();
            - Allows us to create state variables
            - What is State?
                - Variables that are directly tied to the rendering of the component
                - If this variable changes, then it should reflect on the display of the component

        - useEffect()
            - Used when you want something done as soon as the page or component loads in
            - Has multiple functionalities built into it, we will focus on the functionality of doing something when the page loads
*/

function Hooks() {

    async function getPokemon(){
        // let response = await fetch("https://pokeapi.co/api/v2/pokemon/ditto");
        // let responseBody = await response.json();

        // console.log(responseBody);

        /*
            Axios vs Fetch
            Axios is essentially built on top of Fetch and aims to make various QoL improvements for the developer
            One example, you do not have to do a .json(); for your requests
        */
        let response = await axios.get(`https://pokeapi.co/api/v2/pokemon/${state.counter}`);
        // console.log(response.data);
        setPokemon(response.data);
    }
    // useEffect();
    /*
        When the component first loads, the useEffect function is triggered
        Whatever is inside the function is done, and then it does nothing else (for now)
    */

    useEffect(() => {
        // console.log("useEffect triggered");
        getPokemon();
    }, []);

    let [pokemon, setPokemon] = useState<Pokemon | undefined>(undefined);


    // let isVisible = true;

    // useState();
    // We get back two values from this hook
    // the variable that is tied to state
    // the function that needs to be used to update the state variable and trigger a re-render for the component
    // let [visibility, setVisibilty] = useState(true);
    // let [counter, setCounter] = useState(0);

    // State objects that manage the entire state of the components instead of individual state variables are a helpful way to organize your code and states.
    // It makes adding and removing state variables much less time consuming
    let [state, setState] = useState({
        visibility: false,
        counter: 1,
        username: "user1"
    });

    function toggleDiv(){
        // console.log("Toggle function triggered");
        console.log(state.visibility);
        // isVisible = !isVisible;
        // visibility = !visibility; // do not do this
        // setVisibilty(!visibility);
        
        // Spread Operator - ...
        // It is a quick way of duplicating an object, and only changing the values that you need to change
        setState({...state, visibility: !state.visibility});
    }

    function incrementNum(){
        console.log(state.counter);
        // counter++;
        // setCounter(++counter);
        setState({...state, counter: ++state.counter});
        getPokemon();
    }

    function decrementNum(){
        // setCounter(--counter);
        setState({...state, counter: --state.counter});
        getPokemon();
    }

  return (
    <div>
        <button onClick={toggleDiv}>Toggle</button>
        {
            state.visibility ? <h2>Am I visible?</h2> : <></>
        }

        <h1>{state.counter}</h1>
        <button onClick={incrementNum}>Increment</button>
        <button onClick={decrementNum}>Decrement</button>

        {
            <>
                <h2>{pokemon?.name}</h2>
                <img src={pokemon?.sprites.front_default}></img>
            </>
            
        }
    </div>
  )
}

export default Hooks
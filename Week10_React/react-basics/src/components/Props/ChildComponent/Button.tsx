import React from 'react'


//Child Component

function Button(props: {bgColor:string, isRound?: boolean}) {
    console.log(props);
    //Ternary Operator 
    //shorthand for if else statements 

    //condition is checked ? true_statement : false_statement
    return (
      <button style={{
          backgroundColor: props.bgColor,
          color: "white",
          border: "none",
          borderRadius: props.isRound? "60px": "0px",
          padding: "8px",
          fontSize: "20px"
      }}>Click Me</button>
    )
  }

export default Button
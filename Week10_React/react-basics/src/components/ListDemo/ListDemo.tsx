import React from 'react'

function ListDemo() {
  let people = [
    {
        firstName: "John",
        lastName: "Doe"
    },
    {
        firstName: "Jane",
        lastName: "Doe"
    },
    {
        firstName: "Mick",
        lastName: "Doe"
    },
];
  ////
    return (
    // The <> fragment tag lets you not have to use <div> as the parent and have a bunch of nested <div> in your page
    // This helps organize your code and also helps screen readers understand what they are looking at specifically, not a bunch of nested divs
    <>
        ListDemo
        {
             /*
                To display each item in an array to the DOM, we use the map function
                The map function transforms each item in an array in a specific way that you can define
                
                Key is used to uniquely identify each element of the array
                React uses this to quickly figure out which element is being interacted with, otherwise it will need to go through the entire array and that is far more inefficient
            */

            people.map((obj, index)=> {
                return(
                    <div key ={index}>
                        <h1>{obj.firstName}</h1>
                        {obj.lastName}
                    </div>
                );
            })
        }
    </>
  )
}

export default ListDemo
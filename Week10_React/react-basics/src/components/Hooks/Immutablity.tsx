import React, { useState } from 'react'
 
function Immutability() {
    const [items, setItems] = useState<any>([
        /* some items*/
    ]);
 
    let count = 0;
 
    function addItem(){
        // incorrect example
        // We are going to mutate state directly
        // mutating state is where you are updating the state variable directly
 
        // We are first pushing an array item
        // items.push({id: ++count, value: 'new item'});
        // Then we are saving the state variable using the setter with the state variable
        // setItems(items);
        // console.log(items);
 
        // When you directly update the state variable, and then call the update function
        // React is unable to tell the difference and assumes nothing has changed, and so the render function is not called
 
        // The render function is only called, if React sees a difference in the variable you are setting it to be and the current value is different
 
        // We have to call the setter function only, do not update the state directly
        // Updating the state directly leads to a lot of problems, mostly inconsistent behaviors from React.
 
        setItems([
            ...items,
            {id: ++count, value: 'new item'}
        ])
    }
 
  return (
    <div>
        <button onClick={addItem}>Add Item</button>
        <ul>
            {
                items.map((item: any, index: number) => {
                    return <li key={index}>{item.value}</li>
                })
            }
        </ul>
    </div>
  )
}
 
export default Immutability
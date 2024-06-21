import React from 'react'
import './FruitDisplay.css';
import Fruit from '../../models/Fruit';

function FruitDisplay(props: {fruit: Fruit}) {

  return (
    <div className="fruit-container" key={props.fruit.fruitId}>
        <h2 className='fruit-name'>{props.fruit.name}</h2>
        <p className='fruit-price'>{props.fruit.price}</p>
        <p className='fruit-availability'>{props.fruit.isAvailable ? "Available" : "Not Available"}</p>
    </div>
  )
}

export default FruitDisplay
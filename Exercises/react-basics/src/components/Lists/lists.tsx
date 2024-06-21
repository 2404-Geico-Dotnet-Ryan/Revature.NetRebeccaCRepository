import React from 'react'
import FruitDisplay from '../Props/FruitDisplay';
import Fruit from '../../models/Fruit';



function Lists() {

    let fruits: Fruit[] = [
        {fruitId: 1, name: "Apple", price: 2.00, isAvailable: true},
        {fruitId: 23223, name: "Banana", price: 2.00, isAvailable: true},
        {fruitId: 1583, name: "Pineapple", price: 5.00, isAvailable: false},
        {fruitId: 1994, name: "Tangerine", price: 2.00, isAvailable: true},
    ];

  return (
    <>
        {
            fruits.map((obj: Fruit) => {
                return (
                    <FruitDisplay fruit={obj}/>
                );
            })
        }
    </>
  )
}

export default Lists
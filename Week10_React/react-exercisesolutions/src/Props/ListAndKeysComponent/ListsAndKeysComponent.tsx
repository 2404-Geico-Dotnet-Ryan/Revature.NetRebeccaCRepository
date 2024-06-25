import React, { useEffect, useState } from 'react'
import ProductComponent from '../ProductComponent/ProductComponent';


/*
    In order to actually list something using the map function, we need data.

    We can either hardcode the data in, or use an api to get the data

    In this example, I will be using a fetch request
    'https://dummyjson.com/products'

    to get the dummy data

*/

function ListsAndKeysComponent() {

    /*
        We use the useEffect hook in order run a function as soon as the component loads in
        This is set to only run when the component loads in (by setting the [] as empty)
        When the useEffect hook runs, it runs whatever is in the function passed into it

        What we have done, is created a function, that defines an async function and then calls it from within
    */

    // We need to use a state variable because when this value updates, we want the page to re render. Currently it is updating, but the component is not being re rendered

    // let products: any[] =  [];

    const [products, setProducts] = useState<any[] | undefined>(undefined);
    
    useEffect(() => {
        async function getProducts(){
            try{
                let response = await fetch('https://dummyjson.com/products');
                let data = await response.json();
                setProducts(data.products);
            }catch(error){
                console.error(error);
            }
        }
        getProducts();
    }, []);


    /*
        We use the map function in order to iterate over each element of the array and create a component for it
        This piece of the full array of components, must have a key associated with it so that React can efficiently identify which element you are interacting with as the page runs.
    */
  return (
    <div>
        {
            products?.map((obj, index) => {
                return (
                    <ProductComponent product={obj} key={index}/>
                );
            })
        }
    </div>
  )
}

export default ListsAndKeysComponent
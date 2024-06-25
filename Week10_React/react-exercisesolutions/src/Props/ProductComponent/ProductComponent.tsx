import React from 'react'

function ProductComponent({product, key}: {product: any, key: number})
 {
    console.log(product);
  return (
    <div key = {key}>
      <h1>{product.title}</h1>
      <p>{product.description}</p>
      {/* <NewListChild PColor="cyan" FontSize = "40px"/> */}
      <h2>{user?.username}</h2>
    </div>
  )
}

export default ProductComponent
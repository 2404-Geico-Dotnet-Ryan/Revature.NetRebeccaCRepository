import React from 'react'

function Demo() {
    let people =[
        {
            firstName: "Happy", 
            lastName: "Gilmore"
        },
        {
            firstName: "Billy", 
            lastName: "Madison"
        },
        {
            firstName: "Peggy", 
            lastName: "Hill"
        }
    ]
  return (
   <>
   {
                people.map((obj, index) => {
                        return (
                            <div className="name-div" key={index}>
                                <h1>{obj.firstName}</h1>
                                {obj.lastName}
                            </div>
                        );
                })
    
            }
        </>
      )
    }
    
    

export default Demo
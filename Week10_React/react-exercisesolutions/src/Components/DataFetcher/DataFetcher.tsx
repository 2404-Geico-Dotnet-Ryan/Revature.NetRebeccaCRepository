import React, { useEffect, useState } from 'react'
import loadingIcon from '../../images/loading_icon.gif';

function DataFetcher() {

    const [data, setData] = useState<any>();
    const [isLoading, setIsLoading] = useState<boolean>(true);

    useEffect(() => {
        async function getData(){
            let response = await fetch('https://jsonplaceholder.typicode.com/posts');
            let data = await response.json();
            await timeout(1000);
            setIsLoading(false);
            setData(data);
        }

        getData();
    }, []);

    function timeout(delay: number) {
        return new Promise( res => setTimeout(res, delay) );
    }


  return (
    <div>
        <ul>
            { isLoading ? <img src={loadingIcon}/> :
                data?.map((post: any) => {
                    return(
                        <li key={post.id}>
                            <h1>{post.title}</h1>
                            <p>{post.body}</p>
                        </li>
                    );
                })
            }
        </ul>
    </div>
  )
}

export default DataFetcher
//async.test.js
import { render, screen } from '@testing-library/react';
import Async from './Async';

describe('Async Component', () => {
    test('renders post if request succeeds', async () => {
        /*Instead of actually sending a request using our test 
        we will be mocking its behavior so that an actual network request is not sent out
        A simulation of it is instead
        We just want to verify that the response back is handled correctly, not that the request is made actually successfully 
        */
        //this is mocking
        window.fetch = jest.fn();
        //This is the fake results
        window.fetch.mockResolvedValueOnce({
            json: async () => [{id: 'p1', title: 'first post'}],
        });

        render(<Async/>);
        // fetch request sends back  a list
        // We want all the lists on this page
        //but because the elements are displayed asynchronously, we cannot use getAllByRole as we have to wait for promise to resolve and the post to be updated in order for the component to re-render the new listitems
        //use find when you are not 100% when it will load right away 
        const listItemElement = await screen.findAllByRole("listitem");
        // We just want to expect that it is not empty
        expect(listItemElement).not.toHaveLength(0);
    })
})
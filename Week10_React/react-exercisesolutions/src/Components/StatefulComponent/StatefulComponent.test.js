import { fireEvent, render, screen } from "@testing-library/react";
import StatefulComponent from "./StatefulComponent";

describe('Stateful Component', () => {
    test('component renders correctly', () => {

        render(<StatefulComponent/>);

        let countElement = screen.getByText('0');
        let buttonElement = screen.getByRole('button');
        let inputElement = screen.getByRole('textbox');

        expect(countElement).toBeInTheDocument();
        expect(buttonElement).toBeInTheDocument();
        expect(inputElement).toBeInTheDocument();
    });

    test('clicking the button will increment the count', () => {
        render(<StatefulComponent/>);

        let countElement = screen.getByText('0');
        let buttonElement = screen.getByRole('button');

        fireEvent.click(buttonElement);

        expect(countElement).toHaveTextContent('1');
    });

    test('typing into the input box will update the text on screen', () => {
        render(<StatefulComponent/>);

        let inputElement = screen.getByRole('textbox');

        fireEvent.change(inputElement, {target: {value: 'Hello'}});

        let updatedText = screen.getByText('Hello');

        expect(updatedText).toBeInTheDocument();
        
    });
});
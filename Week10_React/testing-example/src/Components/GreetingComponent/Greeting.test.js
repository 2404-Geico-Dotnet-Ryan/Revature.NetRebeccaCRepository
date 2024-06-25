import React from 'react';
import { render, screen, fireEvent } from '@testing-library/react';
import Greeting from './Greeting';

//describe is where you can organize tests- you wrap your test in this to group them
describe('Greeting Component rendering and state', () => {
  test('renders "Hello World" and "It\'s nice to meet you" initially', () => {
    //AAA
    //Arrange
    render(<Greeting />);

    const headingElement = screen.getByText('Hello World');
    const paragraphElement = screen.getByText("It's nice to meet you");
    const buttonElement = screen.getByRole('button', { name: /change text!/i});

    expect(headingElement).toBeInTheDocument();
    expect(paragraphElement).toBeInTheDocument();
    expect(buttonElement).toBeInTheDocument();
  });

  test('renders "I have been changed" after button click', () => {
    render(<Greeting />);

    const buttonElement = screen.getByRole('button', { name: /change text!/i });

    fireEvent.click(buttonElement);

    const changedParagraphElement = screen.getByText('I have been changed');

    expect(changedParagraphElement).toBeInTheDocument();
  });
});
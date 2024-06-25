import React from 'react';
import { render, fireEvent } from '@testing-library/react';
import Counter from './Counter';

describe('Counter Component', () => {
  test('renders initial count and buttons', () => {
    // AAA
    // Arrange
    //  - Preparing the tests
    // Act
    //  - Doing the action/s
    // Assert
    //  - Verifying the results

    //Arrange 
    const { getByText } = render(<Counter />);

    // Act
    //  - There is no act, it is just a render check  

    //Assert
    // Check if the component renders with an initial count of 0
    const countElement = getByText('Count: 0');
    expect(countElement).toBeInTheDocument();

    // Check if the "Increment" and "Decrement" buttons are present
    const incrementButton = getByText('Increment');
    const decrementButton = getByText('Decrement');
    expect(incrementButton).toBeInTheDocument();
    expect(decrementButton).toBeInTheDocument();
  });

  test('increments and decrements count when buttons are clicked', () => {
    //Arrange
    const { getByText } = render(<Counter />);

    const incrementButton = getByText('Increment');
    const decrementButton = getByText('Decrement');
    const countElement = getByText('Count: 0');

    //Act
    // Click the "Increment" button
    fireEvent.click(incrementButton);
    //Assert
    expect(countElement).toHaveTextContent('Count: 1');

    // Click the "Decrement" button
    //Act
    fireEvent.click(decrementButton);
    //Assert
    expect(countElement).toHaveTextContent('Count: 0');
  });
})
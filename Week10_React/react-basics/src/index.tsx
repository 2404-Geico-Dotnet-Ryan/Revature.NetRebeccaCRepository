import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
;

/*
this file is the root where all our components are rendered 
we can see the app<app /> component being placed with in <React
*/ 
const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
    <App />
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals


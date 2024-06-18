import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import { BrowserRouter } from 'react-router-dom';
;

/*
this file is the root where all our components are rendered 
we can see the app<app /> component being placed with in <React
*/ 
const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <BrowserRouter><App /></BrowserRouter>)

import React from 'react';
import logo from './logo.svg';
import './App.css';
import BowlerList from './Bowlers/BowlerList';
import Header1 from './Bowlers/Header1';

function App() {
  return (
    <div className="App">
      <Header1 />
      <BowlerList />
    </div>
  );
}

export default App;

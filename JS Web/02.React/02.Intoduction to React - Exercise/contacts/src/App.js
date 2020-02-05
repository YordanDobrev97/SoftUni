import React from "react";
import logo from "./logo.svg";
import "./App.css";
import HeaderContact from './HeaderContact';
import ListBooks from './ListBooks';
import Details from './Details';
import Footer from './Footer';

function App() {
  return (
    <div className="container">
      <HeaderContact />
      <div id="book">
       <ListBooks/>
       <Details/>
      </div>
      <Footer/>
    </div>
  );
}

export default App;

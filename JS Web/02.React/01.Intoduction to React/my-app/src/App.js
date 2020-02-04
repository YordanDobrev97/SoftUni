import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Greeting from "./Greeting";
import { Navbar } from "./Navbar";
import { Footer } from "./Footer";

function Img() {
  return <img src={logo} className="App-logo" alt="logo" />;
}

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Navbar />
        <Greeting />
        <Img />
        <Footer />
      </header>
    </div>
  );
}

export default App;

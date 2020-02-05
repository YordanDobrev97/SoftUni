import React from "react";
import ContactUsers from "./ContactUser";
const data = require("./contacts.json");

class ListBooks extends React.Component {
  constructor() {
    super();
  }
  render() {
    return (
      <div id="list">
        <h1>Contacts</h1>
        <div className="content">
         {
           data.map((el) => 
            <ContactUsers firstName={el.firstName} lastName={el.lastName}/>
           )
         }
        </div>
      </div>
    );
  }
}

export default ListBooks;

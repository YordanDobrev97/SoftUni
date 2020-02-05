import React from "react";

class ContactUsers extends React.Component {
  constructor() {
    super();
  }
  render() {
    return (
      <div className="contact" data-id="id">
        <span className="avatar small">&#9787;</span>
        <span className="title">{this.props.firstName} {this.props.lastName}</span>
      </div>
    );
  }
}

export default ContactUsers;

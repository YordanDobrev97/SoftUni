import React from "react";

function ShowColName(props) {
  return (
    <div class="col">
      <span class="avatar">&#9787;</span>
      <span class="name">{props.firstName}</span>
      <span class="name">{props.lastName}</span>
    </div>
  );
}

function ShowDetailsInfo(props) {
  return (
    <div class="info">
      <span class="info-line">&phone; {props.phone}</span>
      <span class="info-line">&#9993; {props.email}</span>
    </div>
  );
}

function ShowFullInformation() {
  return (
    <div class="content">
          <div class="info">
            <div class="col">
              <ShowColName firstName="Ivan" lastName="Ivanov"></ShowColName>
            </div>
          </div>
            <ShowDetailsInfo phone="0888 123 456" email="i.ivanov@gmail.com"/>
      </div>
    )
}

class Details extends React.Component {
  constructor() {
    super();
  }
  render() {
    return (
      <div id="details">
        <h1>Details</h1>
        <ShowFullInformation/>
      </div>
    );
  }
}

export default Details;

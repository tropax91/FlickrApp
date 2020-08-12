import React, { Component } from 'react';

export class Home extends Component {
    constructor() {
        super();
        this.state = {
            pictures : [],
        };
    }


    componentDidMount() {
        fetch("https://localhost:44325/api/content/FlickrCall")
            .then(response => response.json())
            .then(result => {
                this.setState({ pictures: result })
            })
    }




  render () {
    return (
      <div>
            <h1>Hello, world!</h1>
            {this.state.pictures.map((picture, index) => (
                <img alt="" src={picture} ></img>
                ))}
      </div>
    );
  }
}

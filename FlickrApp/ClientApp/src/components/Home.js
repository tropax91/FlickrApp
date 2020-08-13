import React, { Component } from 'react';
import { Card, Input } from 'reactstrap';

export class Home extends Component {
    constructor() {
        super();
        this.state = {
            pictures: [],
            inputValue: ''
        };
    }


    componentDidMount() {
        fetch("https://localhost:44325/api/content/FlickrCall")
            .then(response => response.json())
            .then(result => {
                this.setState({ pictures: result });
            })
            .catch(err => {
                throw Error(err.message);
            })
    }




  render () {
    return (
        <div>
            <div>
                <Input type="text" placeholder="Search" />
            </div>
            <Card>
                {this.state.pictures.map((picture, index) => (
                    <img alt="" key={index} src={picture} ></img>
                ))}
            </Card>
      </div>
    );
  }
}

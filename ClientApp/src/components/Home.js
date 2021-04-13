import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { sculpts: [], loading: true };
  }

  componentDidMount(){
    this.populateSculptData();
  }

  render () {
    return (
      <div>
        <h1>Hello, world!</h1>
        {/* TODO:

        Search Field, middle of the screen */}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('sculpts');
    const data = await response.json();
    this.setState({ sculpts: data, loading: false });
    console.log(data);
  }
}

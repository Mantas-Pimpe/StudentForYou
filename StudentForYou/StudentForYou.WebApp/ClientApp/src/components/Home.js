import React, { Component } from 'react';
import SignIn from './SignIn';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>
            <SignIn/>
        </div>
    );
  }
}

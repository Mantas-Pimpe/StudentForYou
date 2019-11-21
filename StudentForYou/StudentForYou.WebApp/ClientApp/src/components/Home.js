import React, { Component } from 'react';
import './Home.css';
import QuestionTable from './QuestionTable';


export class Home extends Component {
  static displayName = Home.name;

  render () {
      return (
          <body>
              <div className="header">
                  <h1><strong>Recent questions</strong></h1>
                  <QuestionTable />
              </div>

          </body>
    );
  }
}

import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { AddStudent } from './student/Addstudent'
import { StudentList } from './student/Studentlist'
import { EditStudent } from './student/Editstudent'

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route path='/fetch-data' component={FetchData} />
            <Route path='/add-student' component={AddStudent} />
            <Route path='/Studentlist' component={StudentList} />
            <Route path='/edit/:id' component={EditStudent} />
      </Layout>
    );
  }
}

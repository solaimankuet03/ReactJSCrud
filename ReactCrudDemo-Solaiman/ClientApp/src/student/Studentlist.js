import React, { Component } from 'react';
import axios from 'axios';
import TableRowGenerate from './TableRowGenerate'; 

export class StudentList extends React.Component {
    constructor(props) {
        super(props);
        this.state = {business:[]};
    }
    
    componentDidMount = () => {        
        axios.get('weatherforecast/Studentdetails')
            .then(response => {
                
                this.setState({ business: response.data });
                
            })
            .catch(function (error) {
                console.log(error);
            })  
    }

    tabRow = () => {
        return this.state.business.map(function (item, index) {
            debugger;
            return <TableRowGenerate obj={item} key={index} />; 
        });        
    }

    render() {
        return (
            <div>
                <h4 align="center"></h4>
                <table className="table table-striped" style={{ marginTop: 10 }}>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>RollNo</th>
                            <th>Class</th>
                            <th>Address</th>
                            <th colSpan="4">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.tabRow()}
                    </tbody>
                </table>

            </div>
            );
    }

}
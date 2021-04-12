import React, { Component } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

export default class TableRowGenerate extends React.Component {
    constructor(props) {
        super(props);
        this.state = { };
    }

    DeleteStudent = () => {
        debugger;
        axios.delete('weatherforecast/Deletestudent?id=' + this.props.obj.Id)
            .then(json => {
                if (json.data.Status === 'Delete') {
                    alert('Record deleted successfully!!');
                }
            })
    }

    render() {
        debugger;
        return (
            <tr>
                <td>
                    {this.props.obj.name}
                </td>
                <td>
                    {this.props.obj.rollno}
                </td>
                <td>
                    {this.props.obj.class}
                </td>
                <td>
                    {this.props.obj.address}
                </td>
                <td>
                    <Link to={"/edit/" + this.props.obj.rollno} className="btn btn-success">Edit</Link>
                </td>
                <td>
                    <button type="button" onClick={this.DeleteStudent} className="btn btn-danger">Delete</button>
                </td>
            </tr>  
            );
    }
}
import React, { Component } from 'react';
import { Link } from 'react-router-dom';



export default class CameraManager extends React.Component{
    constructor(){
        super();
        this.state = {cameras : [],filteredCameras: [], inFetch : true,search:"",filtering : false}
    }
    async componentDidMount(){
//        if(this.state.inFetch) return;

        this.setState({inFetch : true});
        let resp = await fetch('https://localhost:44378/api/camera/');
        let data = await resp.json();
        this.setState({cameras : data, inFetch : false});
    }
    filter(e){
        if(this.state.filtering) return;
        this.setState({filtering: true});
        let filtered = this.state.cameras.filter(x => x.model.toLowerCase().includes(e.target.value.toLowerCase()));
        this.setState({filteredCameras : filtered,search : e.target.value,filtering : false});
        console.log(JSON.stringify(filtered))

    }
    render(){
        if(this.state.inFetch){
            return <div>...Loading</div>
        }
        else{
           let cams = this.state.filteredCameras.length > 0 ? this.state.filteredCameras : this.state.cameras;
        return( 
        
        <div>
            <div style={{marginLeft: '0px'}} className="row">
              <input type="text" className="form-control col-sm-4 float-left" value={this.state.search} 
            onChange={this.filter.bind(this) } 
            placeholder="filter by name..."/>
            <Link to="/EditCamera" className=" float-right btn btn-primary">Add Camera</Link>
            </div>
            <br/>
            <br/> 
            <table className="table table-striped table-dark">
            <thead>
                
                    <tr>
                        <td>Model</td>
                        <td><i className="material-icons">edit</i></td>
                        <td><i className="material-icons">delete</i></td>
                    </tr>
            </thead>
            <tbody>
                {cams.map((c,i) => {
                  return (
                    <tr key={i}>
                        <td>{c.model}</td>
                          <td><Link to={{
                              pathname: '/EditCamera',
                              camera : {...c}
                          }}><i className="material-icons">edit</i></Link></td>
                          <td><a href="#"><i className="material-icons">delete</i></a></td>
                  </tr> ) 
                })}
            </tbody>
            </table>
        </div>
        
        )}
    }
}
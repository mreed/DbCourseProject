import React, { Component } from "react";
import headerImage from "../images/Photography.png";
import {NavLink} from 'react-router-dom'
export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div style={{ width: "100%" }}>
        <img
          style={{ width: "100%" }}
          src={headerImage}
          alt="man with camera"
        />
        <div className="row" style={{paddingTop: '10px',margin:'auto 0'}}>
          <div className="col-sm-6">
            <div className="card">
              <div className="card-body">
                <h5 className="card-title">Search</h5>
                <p className="card-text">
                  Search our database for cameras, both current and old, by several categories
                </p>
                <NavLink to="/Search" style={{verticalAlign:'middle',display:'inline-flex'}} className="btn btn-primary">
                    <i className="material-icons">search</i>
                  Start Search
                </NavLink>
             
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

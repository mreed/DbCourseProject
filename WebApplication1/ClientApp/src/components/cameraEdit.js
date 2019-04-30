import React, { Component } from "react";
import { Route } from "react-router";

export default class CameraEdit extends Component {
  constructor(props) {
    super(props);
    if (props.location.camera) {
      this.state = {...props.location.camera };
    } else {
      this.state = {
        
          model: "",
          releaseDate: undefined,
          maxResolution: undefined,
          lowResolution: undefined,
          effectivePixels: undefined,
          zoomWide: undefined,
          zoomTele: undefined,
          normalFocusRange: undefined,
          macroFocusRange: undefined,
          storageIncluded: undefined,
          weight: undefined,
          dimensions: undefined,
          price: undefined
        
      };
    }
    console.log(JSON.stringify(this.state.camera))
  }
  submit(){

  }
  render(){
      return (
      <form onSubmit={this.submit.bind(this)}>
      <div className="form-group">
          <label className="">Model</label>
          <input className="form-control " type="text" value={this.state.model} onChange={(e) => this.setState({camera : {model : e.target.value}})} placeholder="the model's name"/>
      </div>
       <div className="form-group">
          <label>ReleaseDate</label>
          <input className="form-control" type="number" value={this.state.releaseDate} onChange={(e) => this.setState({camera : {releaseDate : e.target.value}})} placeholder=""/>
      </div>
       <div className="form-group">
          <label>MaxResolution</label>
          <input className="form-control" type="number" value={this.state.maxResolution} onChange={(e) => this.setState({camera : {maxResolution : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>LowResolution</label>
          <input className="form-control" type="number" value={this.state.lowResolution} onChange={(e) => this.setState({camera : {lowResolution : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>EffectivePixels</label>
          <input className="form-control" type="number" value={this.state.effectivePixels} onChange={(e) => this.setState({camera : {effectivePixels : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>ZoomWide</label>
          <input className="form-control" type="number" value={this.state.zoomWide} onChange={(e) => this.setState({camera : {zoomWide : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>ZoomTele</label>
          <input className="form-control" type="number" value={this.state.zoomTele} onChange={(e) => this.setState({camera : {zoomTele : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>NormalFocusRange</label>
          <input className="form-control" type="number" value={this.state.normalFocusRange} onChange={(e) => this.setState({camera : {normalFocusRange : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>MacroFocusRange</label>
          <input className="form-control" type="number" value={this.state.macroFocusRange} onChange={(e) => this.setState({camera : {macroFocusRange : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>StorageIncluded</label>
          <input className="form-control" type="number" value={this.state.storageIncluded} onChange={(e) => this.setState({camera : {storageIncluded : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>Weight</label>
          <input className="form-control" type="number" value={this.state.weight} onChange={(e) => this.setState({camera : {weight : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>Dimensions</label>
          <input className="form-control" type="number" value={this.state.dimensions} onChange={(e) => this.setState({camera : {dimensions : e.target.value}})} placeholder=""/>
      </div> <div className="form-group">
          <label>Price</label>
          <input className="form-control" type="number" value={this.state.price} onChange={(e) => this.setState({camera : {price : e.target.value}})} placeholder=""/>
      </div>
      <div className="btn-group">
        <button className="btn btn-primary">Submit</button>
      </div>
      </form>
      )
  }
}

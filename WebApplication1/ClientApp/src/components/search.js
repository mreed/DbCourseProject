import React, { Component } from "react";

export default class Search extends Component {
  constructor() {
    super();
    this.state = {
      cameras: [],
      filteredCameras: [],
      inFetch: true,
      filtering: false,
      search: ""
    };
  }
  async componentDidMount() {
    //        if(this.state.inFetch) return;

    this.setState({ inFetch: true });
    let resp = await fetch("https://localhost:44378/api/camera/");
    let data = await resp.json();
    this.setState({ cameras: data, inFetch: false });
  }
  onSearch(e) {
    if (this.state.filtering) return;
    this.setState({ filtering: true });
    let filtered = this.state.cameras.filter(x =>
      x.model.toLowerCase().includes(e.target.value.toLowerCase())
    );
    this.setState({
      filteredCameras: filtered,
      search: e.target.value,
      filtering: false
    });
//    console.log(JSON.stringify(filtered));
  }
  render() {
    let cams =
      this.state.filteredCameras.length > 0
        ? this.state.filteredCameras
        : this.state.cameras;
    return (
      <div>
        <h2>Search Cameras</h2>

        <div style={{marginBottom: '10px'}} className="row">
          <input
            type="text"
            onChange={this.onSearch.bind(this)}
            value={this.state.search}
          />
          <button className="btn btn-primary">Search</button>
        </div>
        {this.state.filteredCameras.length > 0 && (
          <table className="table table-striped table-dark">
            <thead>
              <tr>
                <td>Model</td>
                <td>ReleaseDate</td>
                <td>MaxResolution</td>
                <td>LowResolution</td>
                <td>EffectivePixels</td>
                <td>ZoomWide</td>
                <td>ZoomTele</td>
                <td>NormalFocusRange</td>
                <td>MacroFocusRange</td>
                <td>StorageIncluded</td>
                <td>Weight</td>
                <td>Dimensions</td>
                <td>Price</td>
              </tr>
            </thead>
            <tbody>
              {cams.map((c, i) => {
                  console.log(JSON.stringify(c))
                return (
                  <tr key={i}>
                    <td>{c.model}</td>
                    <td>{c.releaseDate}</td>
                    <td>{c.maxResolution}</td>
                    <td>{c.lowResolution}</td>
                    <td>{c.effectivePixels}</td>
                    <td>{c.zoomWide}</td>
                    <td>{c.zoomTele}</td>
                    <td>{c.normalFocusRange}</td>
                    <td>{c.macroFocusRange}</td>
                    <td>{c.storageIncluded}</td>
                    <td>{c.weight}</td>
                    <td>{c.dimensions}</td>
                    <td>{c.price}</td>
                  </tr>
                );
              })}
            </tbody>
          </table>
        )}
      </div>
    );
  }
}

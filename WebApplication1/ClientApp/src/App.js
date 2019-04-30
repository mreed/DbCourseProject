import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import CameraManager from './components/cameramanager';
import CameraEdit from './components/cameraEdit';
import Search from './components/search';
export default class App extends Component {
  static displayName = "Camera Finder";

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <AuthorizeRoute path='/EditCamera' component={CameraEdit}/> 
        <AuthorizeRoute path='/Edit' component={CameraManager} />
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
        <Route path="/Search" component={Search}/>
      </Layout>
    );
  }
}


/*
<AuthorizeRoute path='/fetch-data' component={FetchData} />
*/
import React from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";

import Home from "../pages/Home";
import Survey from "../pages/Survey";
import Results from "../pages/Results";
import Greatings from "../pages/Greatings";

import Layout from "../components/Layout";

function App() {
  return (
    <BrowserRouter>
      <Layout>
        <Switch>
          <Route exact path="/" component={Home} />
          <Route exact path="/survey" component={Survey} />
          <Route exact path="/results" component={Results} />
          <Route exact path="/greetings" component={Greatings} />
        </Switch>
      </Layout>
    </BrowserRouter>
  );
}

export default App;

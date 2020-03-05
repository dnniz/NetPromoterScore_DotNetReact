import React from "react";
import { Link } from "react-router-dom";

import "./styles/Greatings.css";

class Greatings extends React.Component {
  render() {
    return (
      <div className="greatings">
        <div className="container">
          <div className="row">
            <div className="offset-md-2 col-md-8 text-center">
              <React.Fragment>
                <h1>¡ Gracias !</h1>
                <p> Ya realizaste nuestra encuesta</p>
              </React.Fragment>
              <Link className="btn btn-primary" to="/">
                Volver al Inicio
              </Link>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Greatings;

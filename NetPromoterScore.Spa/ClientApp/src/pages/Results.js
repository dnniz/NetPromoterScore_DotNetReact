import React from "react";

import "./styles/Results.css";
import api from "../api";
import { Link } from "react-router-dom";

class Results extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      error: null,
      form: {},
      nps: 0.0
    };
  }

  handleObtenerNPS = async () => {
    try {
      const data = await api.result.getNPS();
      this.setState({ nps: data });
    } catch (error) {
      this.setState({ error: error });
    }
  };

  componentDidMount() {
    this.handleObtenerNPS();
  }

  render() {
    return (
      <div className="Survey">
        <br />
        <br />
        <div className="row justify-content-md-center">
          <div className="col-md-6">
            <div className="card">
              <div className="card-header text-center">
                <h3 className="card-title">Net Promoter Score</h3>
              </div>
              <div className="card-body text-center">
                <h6 className="card-subtitle mb-1 text-muted">
                  {this.state.nps}%
                </h6>
                <br />
              </div>
              <div className="card-footer text-muted text-center">
                <Link className="btn btn-primary" to="/">
                  Volver al Inicio
                </Link>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Results;

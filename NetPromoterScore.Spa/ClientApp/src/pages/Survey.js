import React from "react";

import "./styles/Survey.css";
import api from "../api";
import SurveyItem from "../components/SurveyItem";

class Survey extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      error: null,
      // form: {},
      valueSelected: 0
    };
  }

  handleClick = value => {
    this.setState({
      valueSelected: value
    });
  };

  handleContinuarClick = async () => {
    try {
      await api.survey.create(this.state.valueSelected);
      this.props.history.push("/greetings");
    } catch (error) {
      this.setState({ error: error });
    }
  };

  componentDidUpdate() {
    console.log(this.state.valueSelected);
  }

  render() {
    const items = [];
    for (let index = 0; index <= 10; index++) {
      items.push(
        <SurveyItem
          value={index}
          onClick={this.handleClick}
          itemHasSelected={index === this.state.valueSelected}
        />
      );
    }

    return (
      <div className="Survey">
        <br />
        <br />
        <div className="row">
          <div className="col-ls-12">
            <div className="card">
              <div className="card-header text-center">
                <h3 className="card-title">
                  ¿Cuán probable es que recomiende el producto o servicio a un
                  familiar o amigo?
                </h3>
              </div>
              <div className="card-body text-center">
                <h6 className="card-subtitle mb-1 text-muted">
                  Para ello se les pide calificar en una escala de 0 a 10, donde
                  0 es «Muy improbable» y 10 es «Definitivamente lo
                  recomendaría»
                </h6>
                <br />
                <div role="toolbar" aria-label="Toolbar with button groups">
                  <div
                    className="btn-group mr-2"
                    data-toggle="button"
                    role="group"
                    aria-label="First group"
                  >
                    {items}
                  </div>
                </div>
                <br />
              </div>
              <div className="card-footer text-muted">
                <button
                  className="btn btn-primary"
                  onClick={this.handleContinuarClick}
                >
                  Continuar
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Survey;

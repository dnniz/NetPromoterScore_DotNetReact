import React from "react";

import "./styles/Home.css";
import api from "../api";
import LoginModal from "../components/LoginModal";
import RegisterModal from "../components/RegisterModal";

const UserProfiles = {
  Votante: 1,
  Administrador: 2
};

class Home extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      register: false,
      profiles: undefined,
      error: null,
      form: {
        UserName: "",
        Password: "",
        UserProfileId: 0
      }
    };
  }

  handleOpenRegister = async e => {
    try {
      const data = await api.users.listProfiles();
      this.setState({
        register: true,
        profiles: data
      });
    } catch (error) {
      this.setState({ error: error });
    }
  };

  handleChange = e => {
    this.setState({
      form: {
        ...this.state.form,
        [e.target.name]: e.target.value
      }
    });
  };
  handleRegisterUser = async e => {
    e.preventDefault();

    try {
      await api.users.create(this.state.form);
      this.setState({
        register: false
      });
      this.props.history.push("/");
    } catch (error) {
      this.setState({ error: error });
    }
  };

  handleLogin = async e => {
    e.preventDefault();

    try {
      const user = await api.users.login(this.state.form);

      if (user.surveyCarriedOut) {
        this.props.history.push("/greetings");
      } else {
        switch (user.userProfileId) {
          case UserProfiles.Votante:
            this.props.history.push("/survey");
            break;
          case UserProfiles.Administrador:
            this.props.history.push("/results");
            break;
        }
      }

      // this.props.history.push("/");
    } catch (error) {
      this.setState({ error: error });
    }
  };

  handleOpenLogin = e => {
    this.setState({
      register: false
    });
  };

  render() {
    if (this.state.register) {
      return (
        <div className="Home">
          <RegisterModal
            onLogin={this.handleOpenLogin}
            profiles={this.state.profiles}
            formValues={this.state.form}
            onSubmit={this.handleRegisterUser}
            onChange={this.handleChange}
          />
        </div>
      );
    } else {
      return (
        <div className="Home">
          <LoginModal
            onRegister={this.handleOpenRegister}
            onSubmit={this.handleLogin}
            onChange={this.handleChange}
          />
        </div>
      );
    }
  }
}

export default Home;

import React from "react";
import Modal from "./Modal";

import "./styles/Login.css";
function LoginModal(props) {
  return (
    <Modal>
      <div className="LoginModal">
        <h3 className="text-center">
          <span className="font-weight-light">Net</span>
          <span className="font-weight-bold">PromoterScore</span>
        </h3>
        <hr />
        <form onSubmit={props.onSubmit}>
          <p className="text-center">Para continuar, inicie sesión</p>
          <div className="row justify-content-center">
            <div className="col-sm-12">
              <div className="form-group">
                <label>Usuario</label>
                <input
                  type="text"
                  className="form-control"
                  name="UserName"
                  onChange={props.onChange}
                />
              </div>
            </div>
          </div>

          <div className="row justify-content-center">
            <div className="col-sm-12">
              <div className="form-group">
                <label>Contraseña</label>
                <input
                  type="password"
                  className="form-control"
                  name="Password"
                  onChange={props.onChange}
                />
              </div>
            </div>
          </div>
          <div className="row justify-content-center">
            <div className="col-sm-10">
              <button className="btn btn-primary btn-block text-center">
                Ingresar
              </button>
            </div>
          </div>
        </form>
        <hr />
        <div className="text-center">
          <button className="btn btn-link" onClick={props.onRegister}>
            Registrarse
          </button>
        </div>
      </div>
    </Modal>
  );
}

export default LoginModal;

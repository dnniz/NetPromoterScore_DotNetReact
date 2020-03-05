import React from "react";
import ReactDOM from "react-dom";

import "./styles/Modal.css";

function Modal(props) {
  return ReactDOM.createPortal(
    <div className="Modal">
      <div className="Modal__container">
        {/* <button onClick={props.onClick} className="Modal__close-button">
          X
        </button> */}
        {props.children}
      </div>
    </div>,
    document.getElementById("modal")
  );
}

export default Modal;

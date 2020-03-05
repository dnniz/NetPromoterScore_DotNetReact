import React from "react";

function SurveyItem(props) {
  return (
    <input
      type="button"
      className={
        props.itemHasSelected
          ? `btn btn-secondary selected`
          : `btn btn-secondary`
      }
      value={props.value}
      onClick={() => {
        props.onClick(props.value);
      }}
    />
  );
}

export default SurveyItem;

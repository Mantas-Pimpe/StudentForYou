import React from "react";

class UserHeader extends React.Component {
  render() {
    return (
      <>
        <div
          className="header bg-gradient-default pt-5 pt-lg-8 d-flex align-items-center"
          style={{
            minHeight: "256px",
            backgroundSize: "cover",
            backgroundPosition: "center top"
          }}

        >
          {/* Mask */}
          <span className="mask bg-gradient-default opacity-8" />
          {/* Header container */}
        </div>
      </>
    );
  }
}

export default UserHeader;

import React from "react";
import { Link } from "react-router-dom";

function NavBar() {
  return (
    <nav className="navbar navbar-expand-lg bg-body-tertiary">
      <div className="container-fluid">
          <div className="navbar-nav">
            <Link className="nav-link" to="/">
              Home
            </Link>
            <Link className="nav-link" to="/events">
              Events
            </Link>
            <Link className="nav-link" to="/list">
              Lists
            </Link>
            <Link className="nav-link" to="/listandkeys">
              ListandKeys
            </Link>
            <Link className="nav-link" to="/productcomponent">
              Product
            </Link>
          </div>
      </div>
    </nav>
  );
}

export default NavBar;
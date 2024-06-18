import { Link } from "react-router-dom";


function NavBar() {
    return (
      <nav className="navbar navbar-expand-lg bg-body-tertiary">
        <div className="container-fluid">
          <div className="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div className="navbar-nav">
              <Link className="nav-link" to="/">
                Home
              </Link>
              <Link className="nav-link" to="/events">
                Events
              </Link>
              <Link className="nav-link" to="/lists">
                List
              </Link>
              <Link className="nav-link" to="/props">
                Props    
              </Link>
            </div>
          </div>
        </div>
      </nav>
    );
  }

export default NavBar
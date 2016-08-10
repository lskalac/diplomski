import React, {PropTypes} from 'react';
import {Link, IndexLink} from 'react-router';

const Header = () => {
  return(
      <nav>
        <IndexLink to="/" activeClassName="active"> Home </IndexLink>
        {" | "}
        <Link to="/tasks" activeClassName="active"> Tasks </Link>
        {" | "}
        <Link to="/notes" activeClassName="active"> Notes </Link>
      </nav>
  );
};

export default Header;

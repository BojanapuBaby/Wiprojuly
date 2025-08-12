import React, {Component} from 'react';
import './usersearch.scss'
// import { connect } from "react-redux";
// import { bindActionCreators } from "redux";
// import * as usersearchActions from "../../store/usersearch/actions";
export default class usersearch extends Component {
    // constructor(props) {
    //     super(props);
    //     this.state = {};
    // }
    render() {
      return <div className="component-usersearch">Hello! component usersearch</div>;
    }
  }
// export default connect(
//     ({ usersearch }) => ({ ...usersearch }),
//     dispatch => bindActionCreators({ ...usersearchActions }, dispatch)
//   )( usersearch );
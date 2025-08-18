import React, {Component} from 'react';
import './third.scss'
// import { connect } from "react-redux";
// import { bindActionCreators } from "redux";
// import * as thirdActions from "../../store/third/actions";
export default class third extends Component {
    // constructor(props) {
    //     super(props);
    //     this.state = {};
    // }
    render() {
      return <div className="component-third">Hello! component third</div>;
    }
  }
// export default connect(
//     ({ third }) => ({ ...third }),
//     dispatch => bindActionCreators({ ...thirdActions }, dispatch)
//   )( third );
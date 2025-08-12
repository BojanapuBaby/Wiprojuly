import React, {Component} from 'react';
import './four.scss'
// import { connect } from "react-redux";
// import { bindActionCreators } from "redux";
// import * as fourActions from "../../store/four/actions";
export default class four extends Component {
    // constructor(props) {
    //     super(props);
    //     this.state = {};
    // }
    render() {
      return <div className="component-four">Hello! component four</div>;
    }
  }
// export default connect(
//     ({ four }) => ({ ...four }),
//     dispatch => bindActionCreators({ ...fourActions }, dispatch)
//   )( four );
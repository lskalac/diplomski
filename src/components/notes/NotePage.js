import React, {PropTypes} from 'react';

class NotePage extends React.Component{
  render(){
    return(
      <div className="notes">
        <h1 className="mainTitle"> Note Page </h1>

        <div className="row">
          <div className="input-group col-md-3">
            <input type="text" className="form-control" placeholder="Search note..."></input>
              <span className="input-group-btn">
                <button className="btn btn-default" type="button">Go!</button>
              </span>
            </div>
        </div>

        <h3> Active notes </h3>
        <div className="row activeNotes">
          <h4 className="col-md-2"> Note_1 </h4>
          <p className="col-md-7"> Lorem ipsum dolor sit amet,
             summo soleat prodesset ex nec, cum no nonumy possit,
             sint fuisset pro in. Cum ne aliquip phaedrum, affert
             viderer accusam ut pro. Ea pro nominati delicata
             forensibus, an discere detraxit accusamus his, pericula
             instructior intellegebat ea eos. In vis dicam congue,
             te vituperata quaerendum suscipiantur mea.
             Ut semper discere scripserit vel. Et habeo scaevola ius,
             pri ea autem essent.</p>
           <button type="button" className="btn btn-danger col-md-1">Delete</button>
           <button type="button" className="btn btn-success col-md-1">Edit</button>
        </div>

        <h3> Notebook </h3>
        <div className="row notebook">
          <div className="col-md-6">
            <div className="row">
              <h4 className="col-md-4"> Note_2 </h4>
              <button type="button" className="btn btn-success col-md-2">Edit</button>
              <button type="button" className="btn btn-danger col-md-2">Delete</button>
            </div>
          </div>
        </div>

        <button type="button" className="btn btn-default btn-lg col-md-2">Add new</button>

      </div>
    );
  }
}

export default NotePage;

import React from 'react';
import {Route, IndexRoute} from 'react-router';
import App from './components/App';
import HomePage from './components/home/HomePage';
import NotePage from './components/notes/NotePage';
import TaskPage from './components/tasks/TaskPage';
import AddNote from './components/notes/AddNote';

export default (
  <Route path="/" component={App}>
    <IndexRoute component={HomePage} />
    <Route path="notes" component={NotePage} />
    <Route path="tasks" component={TaskPage} />
    <Route path="add_note" component={AddNote} />
  </Route>
);

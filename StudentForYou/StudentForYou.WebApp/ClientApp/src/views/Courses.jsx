﻿
import React from "react";
// core components
import Header from "../components/Headers/Header.jsx";
import CoursesAdd from "./examples/CoursesAdd.jsx";
import CoursesDetails from "./examples/CoursesDetails.jsx";
import CoursesChat from "./examples/CoursesChat.jsx";
import CoursesList from "./examples/CoursesList.jsx";
import { BrowserRouter as Router, Route } from "react-router-dom";

class Courses extends React.Component {
    render() {
        return (
            <>
                <div>
                    <Header />
                    <Router>
                        <div>
                            {/* Page content */}
                            <Route path="/admin/courses" exact component={CoursesList} />
                            <Route path="/admin/courses/course-:courseID" component={CoursesDetails} />
                            <Route path="/admin/courses/chat-:courseID" component={CoursesChat} />
                            <Route path="/admin/courses/add-course" component={CoursesAdd} />
                        </div>
                    </Router>
                </div>
            </>
        );
    }
}

export default Courses;

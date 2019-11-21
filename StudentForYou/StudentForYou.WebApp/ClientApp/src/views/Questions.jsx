﻿import React from "react";
// core components
import Header from "../components/Headers/Header.jsx";
import AddQuestion from "./examples/AddQuestion.jsx";
import Index from "./Index";
import { BrowserRouter as Router, Route } from 'react-router-dom';

class Questions extends React.Component {
    render() {
        return (
            <>
                <div>
                    <Header />
                    <Router>
                        <div>
                            {/* Page content */}
                            <Route path="/admin/index"exact component={Index} />
                            <Route path="/admin/index/add-question" component={AddQuestion} />
                        </div>
                    </Router>
                </div>
            </>
        );
    }
}

export default Questions;
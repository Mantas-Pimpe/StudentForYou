
import React from "react";
// reactstrap components
import {
    Button,
    Card,
    CardHeader,
    CardBody,
    FormGroup,
    Form,
    Input,
    Container,
    Row,
    Col
} from "reactstrap";
// core components
import Messenger from "../../components/Chat/Messenger/index.js";
class CoursesChat extends React.Component {
    render() {
        return (
            <div>
                <Messenger />
            </div>
        );
    }
}

export default CoursesChat;


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
                <Container className="mt--7 pl-lg-4 pr-lg-4" fluid>
                    <Row>
                        <Col className="order-xl-1" xl="12">
                            <Card className="bg-secondary shadow">
                                <Messenger />
                            </Card>
                        </Col>
                    </Row>
                </Container>
            </div>
                
        );
    }
}

export default CoursesChat;

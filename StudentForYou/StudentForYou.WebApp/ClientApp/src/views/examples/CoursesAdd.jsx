
import React from "react";
// reactstrap components
import {
    Button,
    Card,
    CardHeader,
    Container,
    Row,
    FormGroup,
    Form,
    Input,
    Col
} from "reactstrap";
// core components
import { Link } from 'react-router-dom';

class CoursesAdd extends React.Component {
    render() {
        return (
            <>
                {/* Page content */}
                <Container className="mt--7" fluid>
                    {/* Table */}
                    <Row >
                        <div className="col">
                            <Card className="bg-secondary shadow">
                                <CardHeader className="bg-white border-0">
                                    <Row className="align-items-center">
                                        <div className="col">
                                            <h3 className="mb-0">Add a new Course</h3>
                                        </div>
                                        <div className="col text-right">
                                            <Link to="/admin/courses">
                                                <Button color="primary" size="sm">Cancel</Button>
                                            </Link>
                                        </div>
                                    </Row>
                                </CardHeader>
                                <Form className="pt-4">
                                    <div className="pl-lg-4 pr-lg-4">
                                        <Row>
                                            <Col md="8">
                                                <FormGroup>
                                                    <label
                                                        className="form-control-label"
                                                        htmlFor="input-question-name">Question name
                                                </label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        id="input-question-name"
                                                        placeholder="A short name that would descripbe your question"
                                                        type="text" required/>
                                                </FormGroup>
                                            </Col>
                                            <Col md="4">
                                                <FormGroup>
                                                    <label
                                                        className="form-control-label"
                                                        htmlFor="input-question-difficulty">
                                                        Difficulty
                                                </label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        id="input-question-difficulty"
                                                        placeholder="Question Difficulty ?/10"
                                                        type="number" min="0" max="10"
                                                        required/>
                                                </FormGroup>
                                            </Col>
                                        </Row>
                                        <Row>
                                            <Col md="12">
                                                <FormGroup>
                                                    <label className="form-control-label">Course description</label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        placeholder="Describe the course, the things you learn, topics..."
                                                        rows="8"
                                                        type="textarea"
                                                        required />
                                                </FormGroup>
                                            </Col>
                                        </Row>
                                        <Row>
                                            <div className="col text-right pb-4">
                                                <Button color="primary" size="sm" type="submit">Save</Button>
                                            </div>
                                        </Row>
                                    </div>
                                </Form>
                            </Card>
                        </div>
                    </Row>
                </Container>
            </>
        );
    }
}
export default CoursesAdd;


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

class AddQuestion extends React.Component {
    render() {
        return (
            <>
                {/* Page content */}
                <Container className="mt--7" fluid>
                    {/* Table */}
                    <Row >
                        <div className="col">
                            <Card className="shadow">
                                <CardHeader className="border-0">
                                    <Row className="align-items-center">
                                        <div className="col">
                                            <h3 className="mb-0">Add a new Question</h3>
                                        </div>
                                        <div className="col text-right">
                                            <Link to="/admin/index">
                                                <Button color="primary" size="sm">Cancel</Button>
                                            </Link>
                                        </div>
                                    </Row>
                                </CardHeader>
                                <Form>
                                    <hr className="my-4" />
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
                                                        placeholder="A short name that would describe your question"
                                                        type="text" required />
                                                </FormGroup>
                                            </Col>
                                        </Row>
                                        <Row>
                                            <Col md="12">
                                                <FormGroup>
                                                    <label className="form-control-label">Question description</label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        placeholder="Describe your question"
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
export default AddQuestion;

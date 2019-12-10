
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
import { Link } from 'react-router-dom';

class QuestionDetails extends React.Component {
    constructor(props) {
        super(props);
    }
    state = {
        loading: true,
        question: null,
        checker: 0
    };

    async componentDidMount() {
        this.getQuestion();
    }

    async getQuestion() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/question/GetOneQuestion/" + params.questionID;
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ question: data, loading: false });
    }

    addLike() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/Question/addLike/" + params.questionID;
        fetch(url, {
            method: 'PUT',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(response => {
            return response.json()
        })
    }

    addDislike() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/Question/addDislike/" + params.questionID;
        fetch(url, {
            method: 'PUT',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(response => {
            return response.json()
        })
    }

    DeleteCourse() {
        const { match: { params } } = this.props;
        fetch("https://localhost:44341/api/Question/DeleteCourse/" + params.questionID, {
            method: 'DELETE',
            headers: { 'content-type': 'application/json' },
            body: JSON.stringify({ questionID: params.questionID })
        })
            .then(res => res.json())
            .then(res => console.log(res))
    }

    render() {
        if (!this.state.question) {
            /*If course is null*/
            return <div></div>;
        }
        if (this.state.loading) {
            /*While info is loading from DB*/
            return <div></div>;
        }
        return (
            <div>
                <Container className="mt--7 pl-lg-4 pr-lg-4" fluid>
                    <Row>
                        <Col className="order-xl-1" xl="12">
                            <Card className="bg-secondary shadow">
                                <Form>
                                    <CardHeader className="bg-white border-0">
                                        <Row className="justify-content-md-center">
                                            <Col xs="9">
                                                <h3 className="mb-0"> {this.state.question.questionName} Details</h3>
                                            </Col>
                                            <Col className="text-right" lg="3">
                                                <Link to="/admin/index">
                                                    <Button
                                                        onClick={() => this.DeleteCourse()}
                                                        type="submit"
                                                        color="primary"
                                                        size="sm">
                                                        DeleteCourse
                                                    </Button>
                                                </Link>
                                                <Button
                                                    onClick={() => this.addLike()}
                                                    type="submit"
                                                    color="primary"
                                                    size="sm">
                                                    <i class="fa fa-thumbs-up" />
                                                </Button>
                                                <Button
                                                    onClick={() => this.addDislike()}
                                                    type="submit"
                                                    color="primary"
                                                    size="sm">
                                                    <i class="fa fa-thumbs-down" />
                                                </Button>
                                                <Link to="/admin/index" className="pl-1">
                                                    <Button
                                                        type="submit"
                                                        color="primary"
                                                        size="sm">
                                                        Back
                                                    </Button>
                                                </Link>
                                            </Col>
                                        </Row>
                                    </CardHeader>
                                    <CardBody>
                                        <h6 className="heading-small text-muted mb-4">
                                            About the question
                                        </h6>
                                        <div className="pl-lg-4">
                                            <Row>
                                                <Col md="12">
                                                    <FormGroup>
                                                        <label
                                                            className="form-control-label"
                                                            htmlFor="input-question-name">Question Title
                                                </label>
                                                        <Input
                                                            className="form-control-alternative"
                                                            id="input-question-name"
                                                            placeholder="Question name"
                                                            value={this.state.question.questionName}
                                                            type="text" required />
                                                    </FormGroup>
                                                </Col>
                                            </Row>
                                        </div>
                                        <hr className="my-4" />
                                        {/* Description */}
                                        <h6 className="heading-small text-muted mb-4">Detailed Question Information</h6>
                                        <div className="pl-lg-4">
                                            <Col md="12">
                                                <FormGroup>
                                                    <label className="form-control-label">Question</label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        placeholder="Ask your question in detail"
                                                        rows="8"
                                                        value={this.state.question.questionText}
                                                        type="textarea"
                                                        required />
                                                </FormGroup>
                                            </Col>
                                        </div>

                                    </CardBody>
                                </Form>
                            </Card>
                        </Col>
                    </Row>
                </Container>
            </div>
        );
    }
}

export default QuestionDetails;

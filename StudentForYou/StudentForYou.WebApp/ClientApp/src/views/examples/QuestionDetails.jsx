
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
        if (this.state.checker == 0) {
            const { match: { params } } = this.props;
            const url = "https://localhost:44341/api/question/GetOneQuestion/" + params.questionID;
            const response = await fetch(url);
            const data = await response.json();
            this.setState({ question: data, loading: false });
            this.state.checker = 10;
        }
        if (this.state.checker == 1) {

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
            this.state.checker = 10;
        }
        if (this.state.checker == 2) {
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
            this.state.checker = 10;
        }
    }

    addLike() {
        this.state.checker = 1;
        this.componentDidMount();
    }
    addDislike() {
        this.state.checker = 2;
        this.componentDidMount();
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
                                            <Col className = "text-center" xs = "9">
                                                <h3 className="mb-0"> {this.state.question.questionName}</h3>
                                            </Col>
                                            <Col className="text-right" xs lg="0">
                                                <Link to="/admin/index">
                                                    <Button
                                                        type="submit"
                                                        color="primary"
                                                        size="sm">
                                                        Back
                                                    </Button>
                                                </Link>
                                            </Col>
                                            <Col className="text-right" xs lg="0">
                                                <Button
                                                    onClick={this.addLike}
                                                    type="submit"
                                                    color="primary"
                                                    size="sm">
                                                    Like
                                                </Button>
                                            </Col>
                                            <Col className="text-right" xs lg="0">
                                                <Button
                                                    onClick={this.addDislike}
                                                    type="submit"
                                                    color="primary"
                                                    size="sm">
                                                    Dislike
                                                </Button>
                                            </Col>
                                        </Row>
                                    </CardHeader>
                                    <CardBody>
                                        <h6 className="heading-small text-muted mb-4">
                                            Course Information
                                        </h6>
                                        <div className="pl-lg-4">
                                            <Row>
                                                <Col md="8">
                                                    <FormGroup>
                                                        <label
                                                            className="form-control-label"
                                                            htmlFor="input-question-name">Course title
                                                </label>
                                                        <Input
                                                            className="form-control-alternative"
                                                            id="input-question-name"
                                                            placeholder="The title of the course"
                                                            value={this.state.question.questionName}
                                                            type="text" required />
                                                    </FormGroup>
                                                </Col>
                                                <Col md="4">
                                                    <FormGroup>
                                                        <label
                                                            className="form-control-label"
                                                            htmlFor="input-question-difficulty">
                                                            Difficulty
                                                </label>
                                                    </FormGroup>
                                                </Col>
                                            </Row>
                                        </div>
                                        <hr className="my-4" />
                                        {/* Description */}
                                        <h6 className="heading-small text-muted mb-4">Detailed Course Information</h6>
                                        <div className="pl-lg-4">
                                            <Col md="12">
                                                <FormGroup>
                                                    <label className="form-control-label">Course description</label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        placeholder="Describe the course, the things you learn, topics..."
                                                        rows="8"
                                                        value={this.state.question.questionText}
                                                        type="textarea"
                                                        required />
                                                </FormGroup>
                                            </Col>
                                        </div>
                                        <hr className="my-4" />
                                        {/* Files*/}
                                        <h6 className="heading-small text-muted mb-4">Course Files</h6>
                                        <div className="pl-lg-4">
                                            <Col md="12">
                                                <FormGroup>
                                                    <label className="form-control-label">Images containing helpful course information</label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        placeholder="Describe the course, the things you learn, topics..."
                                                        rows="8"
                                                        type="textarea" />
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


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
        this.addLikeForAnswer = this.addLikeForAnswer.bind(this);
    }
    state = {
        loading: true,
        question: null,
        'items': [],
        commentText: '',
        userID: '',
        questionID: ''
    };

    async componentDidMount() {
        this.getQuestion();
        /*this.addView();*/
        this.GetAnswers();
    }

    async getQuestion() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/question/GetOneQuestion/" + params.questionID;
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ question: data, loading: false });

    }

    async GetAnswers() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/question/getComments/ " + params.questionID;
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'items': results }));
    }

    answersSubmitHandler = e => {
        const { match: { params } } = this.props;
        e.preventDefault();
        const data = {
            commentText: this.state.commentText,
            questionID: parseInt(params.questionID),
            userID: 0
        };
        console.log(data);
        console.log("https://localhost:44341/api/Question/PostQuestionAnswer/" + params.questionID);

        fetch('https://localhost:44341/api/Question/PostQuestionAnswer/' + params.questionID, {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data)
        })
        window.location.reload();
    }

    changeHandler = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }

    addView() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/Question/addView/" + params.questionID;
        fetch(url, {
            method: 'PUT',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(response => {
            return response.json()
        })
    }

    addLike() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/Question/addLike/" + params.questionID;
        fetch(url, {
            method: 'POST',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(response => {
            return response.json()
        })
    }

    addLikeForAnswer(commentID) {
        console.log(commentID);
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/Question/addLikeForAnswer/" + commentID;
        console.log(url);
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
            method: 'POST',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(response => {
            return response.json()
        })
    }

    DeleteQuestion() {
        const { match: { params } } = this.props;
        fetch("https://localhost:44341/api/Question/DeleteQuestion/" + params.questionID, {
            method: 'DELETE',
            headers: { 'content-type': 'application/json' },
            body: JSON.stringify({ questionID: params.questionID })
        })
            .then(res => res.json())
            .then(res => console.log(res))
    }

    addAnswer() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/Question/addAnswer/" + params.questionID;
        fetch(url, {
            method: 'PUT',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(response => {
            return response.json()
        })
    }

    render() {
        const { commentText } = this.state;
        const { commentID } = this.state;
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
                                                <Link to="/admin/index" className="mr-3">
                                                    <Button
                                                        onClick={() => this.DeleteQuestion()}
                                                        type="submit"
                                                        color="primary"
                                                        size="sm">
                                                        Delete question
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
                                        <hr className="my-4" />
                                        {/* Question answers */}
                                        <h6 className="heading-small text-muted mb-4">Question answers</h6>
                                        <div className="pl-lg-5 pr-lg-5">
                                            {this.state.items.map((item) => (
                                                <Row className="mb-4">
                                                    <Col md="11">
                                                        <Input
                                                            className="form-control-alternative"
                                                            placeholder="Ask your question in detail"
                                                            rows="2"
                                                            align="left"
                                                            value={item.commentText}
                                                            type="textarea"
                                                            readonly/>
                                                    </Col>
                                                    <Col md="1">
                                                       <Row className="mb-1">
                                                          <Button
                                                            align="left"
                                                            onClick={() => {
                                                                console.log(item.commentID);
                                                                this.addLikeForAnswer.call(this, item.commentID);
                                                            }}
                                                            type="submit"
                                                            color="primary"
                                                            size="sm">
                                                            <i class="fas fa-angle-double-up"></i>
                                                          </Button>
                                                       </Row>
                                                       <Row className="mb-1">
                                                          <Button
                                                            align="left"
                                                            type="submit"
                                                            color="primary"
                                                            size="sm">
                                                            <i class="fas fa-trash"></i>
                                                          </Button>
                                                       </Row>
                                                    </Col>
                                                </Row>

                                                    ))}
                                        </div>
                                        {/*New answer*/}
                                        <div className="pl-lg-4">
                                            <Col md="12">
                                                <Form onSubmit={this.answersSubmitHandler}>
                                                    <Row>
                                                        <Col className="pt-4 mb-0">
                                                            <Input
                                                                className="form-control-alternative"
                                                                name="commentText"
                                                                value={commentText}
                                                                onChange={this.changeHandler}
                                                                placeholder="Write a answer"
                                                                type="text" required />
                                                        </Col>
                                                    </Row>
                                                    <Row>
                                                        <Col className="text-right pt-4 mb-0" >
                                                            <Button color="primary" size="sm" type="submit" onClick={() => this.addAnswer()} >Save answer</Button>
                                                        </Col>
                                                    </Row>
                                                </Form>
                                            </Col>
                                        </div>
                                        <hr className="my-4" />
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

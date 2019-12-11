import React from "react";
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

class CoursesDetails extends React.Component {
    constructor(props) {
        super(props);
    }

    state = {
        loading: true,
        course: null,
        'items': [],
        reviewText: '',
        userID: ''
    }

    componentDidMount() {
        this.GetCourse();
        this.GetReviews();
    }

    GetReviews() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/course/" + params.courseID + "/GetReviews";
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'items': results }));
    }

    DeleteCourse() {
        const { match: { params } } = this.props;
        fetch("https://localhost:44341/api/course/" + params.courseID + "/DeleteCourse", {
            method: 'DELETE',
            headers: { 'content-type': 'application/json' },
            body: JSON.stringify({ courseID: params.courseID })
        })
            .then(res => res.json()) 
            .then(res => console.log(res))
    }

    async GetCourse() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/course/" + params.courseID + "/GetCourse";
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ course: data, loading: false });
    }

    changeHandler = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }

    reviewSubmitHandler = e => {
        const { match: { params } } = this.props;
        e.preventDefault();
        const data = {
            reviewText: this.state.reviewText,
            courseID: parseInt(params.courseID),
            userID: 0
        };
        console.log(data);
        console.log("https://localhost:44341/api/course/" + params.courseID + "/PostReview");

        fetch('https://localhost:44341/api/course/' + params.courseID + '/PostReview', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data)
        })
        window.location.reload();
    }
            

        
    render() {
        const { reviewText } = this.state;
        if (!this.state.course) {
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
                                        <Row className="align-items-center">
                                            <Col xs="8">
                                                <h3 className="mb-0">Course {this.state.course.courseName} Details</h3>
                                            </Col>
                                            <Col className="text-right" xs="4">
                                                <Link to="/admin/courses" className="mr-3">
                                                    <Button
                                                        onClick={() => this.DeleteCourse()}
                                                        type="submit"
                                                        color="primary"
                                                        size="sm">
                                                        Delete course
                                                    </Button>
                                                </Link>
                                                <Link to="/admin/courses"><Button
                                                    type="submit"
                                                    color="primary"
                                                    size="sm"
                                                >
                                                    Save changes
                                            </Button></Link>
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
                                                            value={this.state.course.courseName}
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
                                                        <Input
                                                            className="form-control-alternative"
                                                            id="input-question-difficulty"
                                                            placeholder="Course Difficulty ?/10"
                                                            value={this.state.course.courseDifficulty}
                                                            type="number" min="0" max="10"
                                                            required />
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
                                                        value={this.state.course.courseDescription}
                                                        type="textarea"
                                                        required />
                                                </FormGroup>
                                            </Col>
                                        </div>
                                        <hr className="my-4" />
                                        {/* Reviews */}
                                        <h6 className="heading-small text-muted mb-4">User course reviews</h6>
                                        <div className="pl-lg-4">
                                            <Col md="12">
                                                <Form onSubmit={this.reviewSubmitHandler}>
                                                    {this.state.items.map(function (item, index) {
                                                        return (
                                                            <li> {item.reviewText}</li>
                                                        )
                                                    })}
                                                    <Row>
                                                        <Col className="pt-4 mb-0">
                                                            <Input
                                                                className="form-control-alternative"
                                                                name="reviewText"
                                                                value={reviewText}
                                                                onChange={this.changeHandler}
                                                                placeholder="Write a course review"
                                                                type="text" required />
                                                        </Col>
                                                    </Row>
                                                    <Row>
                                                        <Col className="text-right pt-4 mb-0" >
                                                            <Button color="primary" size="sm" type="submit" >Save Review</Button>
                                                        </Col>
                                                    </Row>
                                                </Form>
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
                                                        placeholder="Course images..."
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

export default CoursesDetails;


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

class CoursesDetails extends React.Component {
    constructor(props) {
        super(props);
    }
    state = {
        loading: true,
        course: null
    };

    async componentDidMount() {
        const { match: { params } } = this.props;
        const url = "https://localhost:44341/api/course/" + params.courseID +"/GetCourse";
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ course: data, loading: false });
    }
    render() {
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
                                            <Col xs="7">
                                                <h3 className="mb-0">Course {this.state.course.courseName} Details</h3>
                                            </Col>
                                            <Col className="text-right" xs="3">
                                            </Col>
                                            <Col className="text-right" xs="2">
                                                <Button
                                                    type="submit"
                                                    color="primary"
                                                    size="sm"
                                                >
                                                    Save changes
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

export default CoursesDetails;

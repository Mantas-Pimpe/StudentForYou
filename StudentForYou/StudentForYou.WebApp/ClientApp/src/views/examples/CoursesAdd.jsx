
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
    constructor(props) {
        super(props)
        this.state = {
            courseName: '',
            courseDifficulty: '',
            courseDescription: ''
        }
    }
    changeHandler = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }

    submitHandler = e => {
        e.preventDefault();
        const data = {
            courseName: this.state.courseName,
            courseDifficulty: parseInt(this.state.courseDifficulty),
            courseDescription: this.state.courseDescription
        };

        fetch('https://localhost:44341/api/course/PostCourse', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data)
        });

        this.props.history.push("/admin/courses");
    }
    render() {
        const { courseName, courseDifficulty, courseDescription } = this.state;
        return (
            <>
                {/* Page content */}
                < Container className="mt--7" fluid >
                    {/* Table */}
                    < Row >
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
                                <Form className="pt-4" onSubmit={this.submitHandler}>
                                    <div className="pl-lg-4 pr-lg-4">
                                        <Row>
                                            <Col md="8">
                                                <FormGroup>
                                                    <label
                                                        className="form-control-label"
                                                        htmlFor="input-course-name">course title
                                                </label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        name="courseName"
                                                        placeholder="A short title that would describe your course"
                                                        value={courseName}
                                                        onChange={this.changeHandler}
                                                        type="text" required />
                                                </FormGroup>
                                            </Col>
                                            <Col md="4">
                                                <FormGroup>
                                                    <label
                                                        className="form-control-label"
                                                        htmlFor="input-course-difficulty">
                                                        Difficulty
                                                </label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        name="courseDifficulty"
                                                        placeholder="course Difficulty ?/10"
                                                        value={courseDifficulty}
                                                        onChange={this.changeHandler}
                                                        type="number" min="0" max="10"
                                                        required />
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
                                                        name="courseDescription"
                                                        value={courseDescription}
                                                        onChange={this.changeHandler}
                                                        rows="8"
                                                        type="textarea"
                                                        required />
                                                </FormGroup>
                                            </Col>
                                        </Row>
                                        <Row>
                                            <div className="col text-right pb-4">
                                                <Button color="primary" size="sm" type="submit" >Save</Button>
                                            </div>
                                        </Row>
                                    </div>
                                </Form>
                            </Card>
                        </div>
                    </Row >
                </Container >
            </>
        );
    }
}
export default CoursesAdd;


import React from "react";
// reactstrap components
import {
    Button,
    Card,
    CardHeader,
    CardFooter,
    Media,
    Pagination,
    PaginationItem,
    PaginationLink,
    Table,
    Container,
    Row
} from "reactstrap";
// core components
import { Link } from 'react-router-dom';

class CoursesList extends React.Component {
    constructor() {
        super();
        this.state = {
            'items': [],
            'mostReviewed': [],
            'amount': 0,
            'average': 0
        }
    }

    getCourses() {
        const url = "https://localhost:44341/api/course/GetCourses";
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'items': results }));
    }

    getCoursesAmount() {
        const url = "https://localhost:44341/api/course/GetCourseAmount";
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'amount': results }));
    }

    getMostReviewed() {
        const url = "https://localhost:44341/api/course/GetMostReviewed";
        console.log('sssssssss');
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'mostReviewed': results }));
    }

    getCoursesAverage() {
        const url = "https://localhost:44341/api/course/GetCourseAverage";
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'average': results }));
    }

    componentDidMount() {
        this.getCourses();
        this.getCoursesAmount();
        this.getCoursesAverage();
        this.getMostReviewed();
    }

    componentDidUpdate() {
        this.getCourses();
        /*this.getCoursesAmount();
        this.getCoursesAverage();
        this.getMostReviewed();*/
    }

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
                                            <h3 className="mb-0">Course List</h3>
                                        </div>
                                        <div className="col text-right">
                                            <Link to="/admin/courses/add-course">
                                                <Button color="primary" size="sm">Add a course </Button>
                                            </Link>
                                        </div>
                                    </Row>
                                </CardHeader>
                                <Table className="align-items-center table-flush" responsive>
                                    <thead className="thead-light">
                                        <tr>
                                            <th scope="col" width="60%" >Course</th>
                                            <th scope="col" width="20%" className="text-center">Difficulty</th>
                                            <th scope="col" width="20%" className="text-center">Course Chat</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {this.state.items.map(function(item, index) {
                                            return (
                                                <tr>
                                                    <th scope="row">
                                                        <Media className="align-items-center">
                                                            <Media>
                                                                <span className="mb-0 text-sm">
                                                                    <Link to={`/admin/courses/course-${item.courseID}`}>{item.courseName}</Link>
                                                                </span>
                                                            </Media>
                                                        </Media>
                                                    </th>
                                                    <td align="center">{item.courseDifficulty}/10</td>
                                                    <td align="center">
                                                        <Link to={`/admin/courses/chat-${item.courseID}`}><Button
                                                            color="primary"
                                                            size="sm"><i class="fa fa-comments"></i>
                                                        </Button></Link>
                                                    </td>
                                                </tr>)
                                        }
                                        )}
                                    </tbody>
                                </Table>
                                <CardFooter className="py-4">
                                    <Row className="align-items-center">
                                        <div className="col text-left">
                                            <h5 className="mb-0">Number of courses: {this.state.amount}</h5>
                                            <h5 className="mb-0">Average of courses: {this.state.average.toFixed(2)}</h5>
                                            {this.state.mostReviewed.map(function(mostReviewed, index) {
                                                return (
                                                    <h5 className="mb-0">Most reviewed course: {mostReviewed.name} ({mostReviewed.value})</h5>
                                                )
                                            })}
                                        </div>
                                    </Row>
                                    <nav aria-label="..." >
                                        <Pagination
                                            className="pagination justify-content-end mb-0"
                                            listClassName="justify-content-end mb-0">
                                            <PaginationItem className="disabled">
                                                <PaginationLink
                                                    href="#pablo"
                                                    onClick={e => e.preventDefault()}
                                                    tabIndex="-1">
                                                    <i className="fas fa-angle-left" />
                                                    <span className="sr-only">Previous</span>
                                                </PaginationLink>
                                            </PaginationItem>
                                            <PaginationItem className="active">
                                                <PaginationLink
                                                    href="#pablo"
                                                    onClick={e => e.preventDefault()}>
                                                    1
                                                </PaginationLink>
                                            </PaginationItem>
                                            <PaginationItem>
                                                <PaginationLink
                                                    href="#pablo"
                                                    onClick={e => e.preventDefault()}
                                                >
                                                    2 <span className="sr-only">(current)</span>
                                                </PaginationLink>
                                            </PaginationItem>
                                            <PaginationItem>
                                                <PaginationLink
                                                    href="#pablo"
                                                    onClick={e => e.preventDefault()}>
                                                    3
                                                </PaginationLink>
                                            </PaginationItem>
                                            <PaginationItem>
                                                <PaginationLink
                                                    href="#pablo"
                                                    onClick={e => e.preventDefault()}>
                                                    <i className="fas fa-angle-right" />
                                                    <span className="sr-only">Next</span>
                                                </PaginationLink>
                                            </PaginationItem>
                                        </Pagination>
                                    </nav>
                                </CardFooter>
                            </Card>
                        </div>
                    </Row>
                </Container>
            </>
        );
    }
}

export default CoursesList;

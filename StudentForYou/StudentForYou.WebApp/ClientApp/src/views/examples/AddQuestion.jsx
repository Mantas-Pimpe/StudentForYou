
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
    constructor(props) {
        super(props);
        this.state = {
            questionName: '',
            allQuestion: '',
            question:[]
        }
        this.handleChange = this.handleChange.bind(this);
        this.AddNewQuestion = this.AddNewQuestion.bind(this);
    }

    handleChange = event => {
        this.setState({ questionName: event.target.value });
    }
    handleChange2 = event => {
        this.setState({ allQuestion: event.target.value });
    }

    AddNewQuestion() {
        const id = this.props.id;
        const name = this.state.questionName;
        const all = this.state.allQuestion;
        const split = '/';
        const url = 'https://localhost:44341/api/Question/newquestion/' + id + split + name + split + all;
        fetch(url, {
            method: 'PUT',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        })
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
                                            <Col md="12">
                                                <FormGroup>
                                                    <label
                                                        className="form-control-label"
                                                        htmlFor="input-question-name">Question name
                                                    </label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        id="input-question-name"
                                                        placeholder="A short name that would describe your question"
                                                        type="text" required
                                                        name="questionName"
                                                        value={this.state.questionName}
                                                        onChange={this.handleChange} />
                                                </FormGroup>
                                            </Col>
                                        </Row>
                                        <Row>
                                            <Col md="12">
                                                <FormGroup>
                                                    <label className="form-control-label">Question description</label>
                                                    <Input
                                                        className="form-control-alternative"
                                                        value={this.state.allQuestion}
                                                        onChange={this.handleChange2}
                                                        placeholder="Describe your question"
                                                        rows="8"
                                                        type="textarea"
                                                        required />
                                                </FormGroup>
                                            </Col>
                                        </Row>
                                        <Row>
                                            <div className="col text-right pb-4">
                                                <Link to={"/admin/index"}>
                                                    <Button
                                                        onClick={this.AddNewQuestion}
                                                        
                                                        color="primary"
                                                        size="sm">
                                                        Ask a question
                                                    </Button>
                                                </Link>
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

import React from "react";
import Chart from "chart.js";
import {
    Media,
    Button,
    Card,
    CardHeader,
    Table,
    Container,
    Row,
    Col,
    InputGroupAddon,
    InputGroupText,
    Input,
    InputGroup,
    CardFooter,
    PaginationItem,
    PaginationLink,
    Pagination
} from "reactstrap";
import {
    chartOptions,
    parseOptions
} from "../variables/charts.jsx";
import { Link } from 'react-router-dom';
import AddQuestion from "./examples/AddQuestion.jsx";

class Index extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            'items': [],
            activeNav: 1,
            chartExample1Data: "data1",
            searchKey: '',
            loading: true,
            'amount': 0,
            firstLoad: true,
            isClicked: 0,
            isClickedQuestion: true
        }
    }

    async getQuestions() {
        const url = "https://localhost:44341/api/Question";
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ 'items': data, loading: false, firstLoad:false });
    }

    async GetQuestionsBySearchKey() {
        const url = "https://localhost:44341/api/Question/getQuestionsSortedBy/" + this.state.searchKey;
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ 'items': []});
        this.setState({ 'items': data, loading: false });
    }

    getQuestionAmount() {
        const url = "https://localhost:44341/api/Question/GetQuestionAmount";
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'amount': results }));
    }

    async componentDidMount() {
        this.getQuestions();
        this.getQuestionAmount();
    }


    async componentDidUpdate(preProps, preState) {
        if (this.state.isClickedQuestion === true) {
            this.getQuestions();
            this.getQuestionAmount();
            this.setState({ isClickedQuestion: false });
        }

        if (this.state.isClicked == 0) {
            this.getQuestions();
            this.getQuestionAmount();
            this.setState({ isClicked: 1 });
        }

        if (this.state.searchKey !== preState.searchKey) {
            this.GetQuestionsBySearchKey();
            if ((this.state.searchKey).length === 0) {
                this.setState({ firstLoad:true });
            }
        }
        if ((this.state.searchKey).length === 0 && this.state.firstLoad === true) {
            this.getQuestions();
        }
    }

    toggleNavs = (e, index) => {
        e.preventDefault();
        this.setState({
            activeNav: index,
            chartExample1Data:
                this.state.chartExample1Data === "data1" ? "data2" : "data1"
        });
        let wow = () => {
            console.log(this.state);
        };
        wow.bind(this);
        setTimeout(() => wow(), 1000);
    };
    componentWillMount() {
        if (window.Chart) {
            parseOptions(Chart, chartOptions());
        }
    }

    addView(questionID) {
        const url = "https://localhost:44341/api/Question/addView/" + questionID;
        fetch(url, {
            method: 'POST',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        })
    }

    whatDo(id) {
        this.addView(id);
        this.setState({ isClickedQuestion: true });
    }


    change() {
        this.setState({ isClicked: 1});
    }

    handleChange = event => {
        this.setState({
            searchKey: event.target.value,
        });
    }

    render() {
        if (this.state.loading) {
            /*While info is loading from DB*/
            return <div></div>;
        }
        return (
            <>
                {/* Page content */}
                <Container className="mt--7" fluid>
                    <Row className="mt-5">
                        <Col className="mb-5 mb-xl-0" xl="12">
                            <Card className="shadow">
                                <CardHeader className="border-0">
                                    <Row className="align-items-center">
                                        <div className="col">
                                            <h3 className="mb-0">Recent Questions</h3>
                                        </div>
                                        <div className="col text-right">
                                            <InputGroup className="input-group-alternative">
                                                <InputGroupAddon addonType="prepend">
                                                    <InputGroupText>
                                                        <i className="fas fa-search"
                                                        />
                                                    </InputGroupText>
                                                </InputGroupAddon>
                                                <Input
                                                    placeholder="Search"
                                                    type="text"
                                                    value={this.state.searchKey}
                                                    onChange={this.handleChange}
                                                    required />
                                            </InputGroup>
                                        </div>
                                        <div className="col text-right">
                                            <Link to="/admin/index/add-question">
                                                <Button color="primary" size="sm" onClick={() => this.change()}>Ask a question </Button>
                                            </Link>
                                        </div>
                                    </Row>
                                </CardHeader>
                                <Table className="align-items-center table-flush" responsive>
                                    <thead className="thead-light">
                                        <tr>
                                            <th scope="col" width="70%">Question</th>
                                            <th scope="col" width="5%">Likes</th>
                                            <th scope="col" width="5%">Views</th>
                                            <th scope="col" width="5%">Answers</th>
                                            <th scope="col" width="15%">Date</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {this.state.items.map((item) => (
                                            <tr>
                                                <th scope="row">
                                                    <Media className="align-items-center">
                                                        <Media>
                                                            <span className="mb-0 text-sm">
                                                                <Link to={`/admin/index/question-${item.questionID}`} onClick={() => this.whatDo(item.questionID)}>{item.questionName}</Link>
                                                            </span>
                                                        </Media>
                                                    </Media>
                                                </th>
                                                <td align="center">{item.questionLikes}</td>
                                                <td align="center">{item.questionViews}</td>
                                                <td align="center">{item.questionAnswers}</td>
                                                <td align="center">{item.questionCreationDate}</td>
                                            </tr>)
                                        )}
                                    </tbody>
                                </Table>
                                <CardFooter className="py-4">
                                    <Row className="align-items-center">
                                        <div className="col text-left">
                                            <h5 className="mb-0">Number of questions: {this.state.amount}</h5>
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
                        </Col>
                    </Row>
                </Container>
            </>
        );
    }
}

export default Index;

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
    Col
} from "reactstrap";
import {
    chartOptions,
    parseOptions
} from "../variables/charts.jsx";
import { Link } from 'react-router-dom';

class Index extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            'items': [],
            activeNav: 1,
            chartExample1Data: "data1"
        }
    }

    GetQuestion() {
        const url = "https://localhost:44341/api/Question";
        fetch(url)
            .then(results => results.json())
            .then(results => this.setState({ 'items': results }));
    }

    componentDidMount() {
        this.GetQuestion();
    }

    componentDidUpdate() {
        this.GetQuestion();
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
        }).then(response => {
            return response.json()
        })
    }

    render() {
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
                                            <Link to="/admin/index/add-question">
                                                <Button color="primary" size="sm">Ask a question </Button>
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
                                                                <Link to={`/admin/index/question-${item.questionID}`} onClick={() => this.addView(item.questionID)}>{item.questionName}</Link>
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
                            </Card>
                        </Col>
                    </Row>
                </Container>
            </>
        );
    }
}

export default Index;

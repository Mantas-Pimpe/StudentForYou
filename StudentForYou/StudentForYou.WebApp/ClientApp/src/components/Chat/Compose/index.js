import React from 'react';
import './Compose.css';
import {
    Button,
    Form
} from "reactstrap";

class Compose extends React.Component {
    constructor() {
        super();
        this.state = {
            courseID: '',
            messageText: '',
            messageSenderID: '0'
        }
    }

    changeHandler = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }

    submitHandler = e => {
        e.preventDefault();
        const data = {
            courseID: parseInt(this.props.courseID),
            messageText: this.state.messageText,
            messageSenderID: parseInt(this.state.messageSenderID)
        };
        fetch('https://localhost:44341/api/groupChat', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data)
        });
        //window.location.reload();

        this.state.messageText = '';
    }

    render() {
        const { messageText } = this.state;
        return (

            <Form onSubmit={this.submitHandler} className="compose">
                <input
                    type="text"
                    className="compose-input"
                    value={messageText}
                    name="messageText"
                    onChange={this.changeHandler}
                    placeholder="Type a message, @name" required />
                <Button
                    className="float-right"
                    type="submit"
                    color="primary"
                    size="sm">
                    Send
                    </Button>
                {this.props.rightItems}
            </Form>

        );
    }
}
export default Compose;
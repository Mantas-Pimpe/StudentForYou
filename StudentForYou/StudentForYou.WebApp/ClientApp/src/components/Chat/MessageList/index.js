import React, { useEffect, useState } from 'react';
import Compose from '../Compose';
import Toolbar from '../Toolbar';
import ToolbarButton from '../ToolbarButton';
import Message from '../Message';
import moment from 'moment';

import './MessageList.css';

const MY_USER_ID = 0;

export default function MessageList(props) {
    const [messages, setMessages] = useState([])

    useEffect(() => {
        getMessages();
    }, [])

    function getMessages() {
        const link = "https://localhost:44341/api/groupChat/" + props.id.id.match.params.courseID + "/Get";
        setInterval(async function () {
            const res = await fetch(link);
            res
            .json()
            .then(res => setMessages(res)); }, 250);
        
    }

    const renderMessages = () => {
        let i = 0;
        let messageCount = messages.length;
        let tempMessages = [];

        while (i < messageCount) {
            let previous = messages[i - 1];
            let current = messages[i];
            let next = messages[i + 1];
            let isMine = current.messageSenderID === MY_USER_ID;
            let currentMoment = moment(current.messageTime);
            let prevBySameAuthor = false;
            let nextBySameAuthor = false;
            let startsSequence = true;
            let endsSequence = true;
            let showTimestamp = true;

            if (previous) {
                let previousMoment = moment(previous.messageTime);
                let previousDuration = moment.duration(currentMoment.diff(previousMoment));
                prevBySameAuthor = previous.messageSenderID === current.messageSenderID;

                if (prevBySameAuthor && previousDuration.as('hours') < 1) {
                    startsSequence = false;
                }

                if (previousDuration.as('hours') < 1) {
                    showTimestamp = false;
                }
            }

            if (next) {
                let nextMoment = moment(next.messageTime);
                let nextDuration = moment.duration(nextMoment.diff(currentMoment));
                nextBySameAuthor = next.messageSenderID === current.messageSenderID;

                if (nextBySameAuthor && nextDuration.as('hours') < 1) {
                    endsSequence = false;
                }
            }

            tempMessages.push(
                <Message
                    key={i}
                    isMine={isMine}
                    startsSequence={startsSequence}
                    endsSequence={endsSequence}
                    showTimestamp={showTimestamp}
                    data={current}
                />
            );

            // Proceed to the next message.
            i += 1;
        }

        return tempMessages;
    }

    return (
        <div className="message-list">
            <Toolbar
                title="Conversation Title"
                rightItems={[
                    <ToolbarButton key="info" icon="ion-ios-information-circle-outline" />,
                    <ToolbarButton key="video" icon="ion-ios-videocam" />,
                    <ToolbarButton key="phone" icon="ion-ios-call" />
                ]}
            />

            <div className="message-list-container">{renderMessages()}</div>

            <Compose rightItems={[
                <ToolbarButton key="photo" icon="ion-ios-camera" />,
                <ToolbarButton key="image" icon="ion-ios-image" />,
                <ToolbarButton key="audio" icon="ion-ios-mic" />,
                <ToolbarButton key="money" icon="ion-ios-card" />,
                <ToolbarButton key="games" icon="ion-logo-game-controller-b" />,
                <ToolbarButton key="emoji" icon="ion-ios-happy" />
            ]} courseID={props.id.id.match.params.courseID}/>
        </div>
    );
}
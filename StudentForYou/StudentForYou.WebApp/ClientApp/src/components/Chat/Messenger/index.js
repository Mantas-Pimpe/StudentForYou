import React from 'react';
import MessageList from '../MessageList';
import './Messenger.css';
import ScrollToBottom from 'react-scroll-to-bottom';

export default function Messenger(props) {
    return (
      <div className="messenger">
            <ScrollToBottom  className="scrollable content">
                <MessageList id={props}/>
            </ScrollToBottom>
      </div>
    );
}
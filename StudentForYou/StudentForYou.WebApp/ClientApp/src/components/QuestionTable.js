import React from 'react'

const QuestionTable = () => (
    <table>
        <thead>
            <tr>
                <th>Question</th>
                <th>Likes</th>
                <th>Views</th>
                <th>Answers</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Laba diena</td>
                <td>0</td>
                <td>25</td>
                <td>30</td>
                <td>
                    <button className="button muted-button">Edit</button>
                    <button className="button muted-button">Delete</button>
                </td>
            </tr>
        </tbody>
    </table>
)

export default QuestionTable
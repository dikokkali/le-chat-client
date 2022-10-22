import { User } from "../common/User";
export class Message {
    id: string;
    senderId: string;
    recipientId: string;
    sessionId: string;
    text: string;
    sentTimestamp: Date;
    seenTimestamp?: Date;

    sender: User;
    recipient: User;
}


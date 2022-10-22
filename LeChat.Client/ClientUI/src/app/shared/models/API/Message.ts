export class Message {
    id: string;
    sourceId: string;
    targetId: string;
    text: string;
    seen: boolean;
    sentAt: Date;
    seenAt: Date;
}
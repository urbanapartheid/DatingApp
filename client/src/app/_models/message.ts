
    export interface Message {
        id: number;
        sourceId: number;
        senderUsername: string;
        senderPhotoUrl: string;
        recipientId: number;
        recipientUsername: string;
        recipientPhotoUrl: string;
        content: string;
        dateRead?: Date;
        messageSent: Date;
    }

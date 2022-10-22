import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Message } from "../../models/API/Message";

@Injectable()
export class MessagingService {  
    
    sessionMessages$: Observable<Message[]>;    

    _messageUrl: string = "";

    getChatSessionMessages(sessionId: string) {

        // TODO: Replace mock
        return [

        ]
    }

    postMessage() {

    }
} 
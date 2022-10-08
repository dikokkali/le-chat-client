import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { MessageViewModel } from "../../models/API/MessageViewModel";

@Injectable()
export class MessagingService {  
    
    sessionMessages$: Observable<MessageViewModel[]>;    

    _messageGetUrl: string = "";
    _messagePostUrl: string = "";

    getChatSessionMessages(sessionId: string) {
    }

    postMessage() {

    }
} 
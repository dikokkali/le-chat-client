import { Component, OnInit } from '@angular/core';
import { ChatBubbleViewModel } from '../../models/UI/ChatBubbleViewModel';

@Component({
  selector: 'chat-display',
  templateUrl: './chat-display.component.html',
  styleUrls: ['./chat-display.component.scss']
})
export class ChatDisplayComponent implements OnInit {

  public typeBoxContent: string;
  public displayedMessages: ChatBubbleViewModel[];  

  constructor() { }

  ngOnInit(): void {

    this.displayedMessages = [
      {
        senderName: "Dimitris",
        senderMessage: "Mpoumpoukitsa mou mikriii"
      }      
    ]
  }

  //#region Setup

  initializeChatWindow() {

    this.typeBoxContent = "";
  }

  clearTextArea() {
    this.typeBoxContent = "";
  }

  //#endregion

  //#region Callbacks

  onSendButtonPressed(e: any) {

    let newMessage = {} as ChatBubbleViewModel;

    newMessage.senderMessage = this.typeBoxContent;
    newMessage.senderName = "Dimitris";

    this.displayedMessages.push(newMessage);

    this.clearTextArea();
  }

  //#endregion

}

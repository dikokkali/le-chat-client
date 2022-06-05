import { Component, OnInit } from '@angular/core';
import { ChatBubbleViewModel } from '../../models/UI/ChatBubbleViewModel';

@Component({
  selector: 'app-chat-window',
  templateUrl: './chat-window.component.html',
  styleUrls: ['./chat-window.component.scss']
})
export class ChatWindowComponent implements OnInit {

  public typeBoxContent: string;
  public displayedMessages: ChatBubbleViewModel[];  

  constructor() { }

  ngOnInit(): void {

    this.displayedMessages = [
      {
        senderName: "Dimitris",
        senderMessage: "Hello, how are you mate?"
      },
      {
        senderName: "Dimitris",
        senderMessage: "Good, you?"
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

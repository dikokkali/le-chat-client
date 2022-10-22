import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'chat-display',
  templateUrl: './chat-display.component.html',
  styleUrls: ['./chat-display.component.scss']
})
export class ChatDisplayComponent implements OnInit {

  public typeBoxContent: string;
  public displayedMessages: any[];  

  constructor() { }

  ngOnInit(): void {
    
  }

  //#region Setup

  clearTextArea() {
    this.typeBoxContent = "";
  }

  //#endregion

  //#region Callbacks

  onSendButtonPressed(e: any) {
 
  }

  //#endregion

}

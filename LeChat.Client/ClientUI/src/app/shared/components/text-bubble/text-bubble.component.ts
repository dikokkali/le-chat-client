import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-text-bubble',
  templateUrl: './text-bubble.component.html',
  styleUrls: ['./text-bubble.component.scss']
})
export class TextBubbleComponent implements OnInit {

  @Input('senderName') name: string;
  @Input('message') message: string;

  constructor() { }

  ngOnInit(): void {
  }

}

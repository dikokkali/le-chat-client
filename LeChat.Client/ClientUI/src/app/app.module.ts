import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChatWindowComponent } from './shared/components/chat-window/chat-window.component';
import { TextBubbleComponent } from './shared/components/text-bubble/text-bubble.component';

@NgModule({
  declarations: [
    AppComponent,
    ChatWindowComponent,
    TextBubbleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

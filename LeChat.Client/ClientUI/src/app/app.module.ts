import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChatDisplayComponent } from './shared/components/chat-display/chat-display.component';
import { TextBubbleComponent } from './shared/components/text-bubble/text-bubble.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatSliderModule } from '@angular/material/slider';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatListModule} from '@angular/material/list';
import {MatSelectModule} from '@angular/material/select';


import { FormsModule } from '@angular/forms';
import { ChatFriendsListComponent } from './shared/components/chat-friends-list/chat-friends-list.component';
import { ChatUiComponent } from './pages/chat-ui/chat-ui.component';
import { FriendsService } from './shared/services/API/friendsService.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    ChatUiComponent,
    ChatDisplayComponent,
    TextBubbleComponent,
    ChatFriendsListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    MatSelectModule,
    HttpClientModule
  ],
  providers: [FriendsService],
  bootstrap: [AppComponent]
})
export class AppModule { }

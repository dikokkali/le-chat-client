import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ChatFriendViewModel } from '../../models/UI/ChatFriendViewModel';
import { FriendsService } from '../../services/API/friendsService.service';

@Component({
  selector: 'chat-friends-list',
  templateUrl: './chat-friends-list.component.html',
  styleUrls: ['./chat-friends-list.component.scss']
})
export class ChatFriendsListComponent implements OnInit {

  public friendsList$: Observable<ChatFriendViewModel[]>;

  constructor(private friendsService: FriendsService) { }

  ngOnInit(): void {
    this.friendsService.getAllUserFriends();
    this.friendsList$ = this.friendsService.friendsList$;
  }

}

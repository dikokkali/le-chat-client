import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject, Observable, of, shareReplay, tap } from "rxjs";
import { ChatFriendViewModel } from "../../models/UI/ChatFriendViewModel";

@Injectable()
export class FriendsService {    

    private _friendsApiUrl: string = "http://localhost:3000/friends";

    public friendsList$: Observable<ChatFriendViewModel[]>;    

    constructor(private httpClient: HttpClient)
    {
        this.friendsList$ = this.getAllUserFriends();
    }
    
    getAllUserFriends() : Observable<ChatFriendViewModel[]>  {  
       return this.httpClient.get<ChatFriendViewModel[]>(this._friendsApiUrl)
       .pipe(
           shareReplay(1)
       )
    }    
}
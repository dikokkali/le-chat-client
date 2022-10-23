import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class UserService {
    constructor() {}

    public setCurrentUser(userObject: any) {
        localStorage.setItem('user', JSON.stringify(userObject));
    }

    public getCurrentUser() {
        const userItem = localStorage.getItem('user');

        if (userItem)
            return JSON.parse(localStorage.getItem('user')!);
        else {
            console.error('Request for null user from UserService');
            return null;
        }
    }
}


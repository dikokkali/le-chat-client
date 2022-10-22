import { Injectable } from "@angular/core";
import { User } from "../../models/common/User";

@Injectable({
    providedIn: 'root'
})
export class UserService {
    constructor() {}

    public setCurrentUser(user: User): void {
        localStorage.setItem('user', JSON.stringify(user));
    }

    public getCurrentUser(): User | null {
        const userItem = localStorage.getItem('user');

        if (userItem)
            return JSON.parse(localStorage.getItem('user')!) as User;
        else {
            console.error('Request for null user from UserService');
            return null;
        }
    }
}


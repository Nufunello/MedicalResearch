import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Department } from "../models/department.model";
import { Rule } from "../models/rule.model";
import { UserAuthorization } from "../models/user-authorization.model";
import { UserRegistration } from "../models/user-registration.mode";

@Injectable()
export class UserService {
    constructor(private readonly _httpClient: HttpClient) {}
    serverApi: 'http://localhost:44382'

    login(entity: UserAuthorization) {
        return this._httpClient.post('https://localhost:44382/users/login', entity,{headers : new HttpHeaders({ 'Content-Type': 'application/json' })})
    }
    
    register(entity: UserRegistration):Observable<number> {
        return this._httpClient.post<number>('https://localhost:44382/users/register', entity, {headers : new HttpHeaders({ 'Content-Type': 'application/json' })}) 
    }

    getRules(): Observable<Rule[]> {
        return this._httpClient.get<Rule[]>(this.serverApi);
    }
}
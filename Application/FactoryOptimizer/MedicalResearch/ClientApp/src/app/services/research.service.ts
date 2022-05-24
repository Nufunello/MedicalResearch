import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Research } from "../models/research.model";
import { Rule } from "../models/rule.model";

@Injectable()
export class ResearchService {
    constructor(private readonly _httpClient: HttpClient) {}
    serverApi: 'http://localhost:44382'

    create(entity: Research): Observable<number> {
        return this._httpClient.post<number>('https://localhost:44382/researches/new', entity, {headers : new HttpHeaders({ 'Content-Type': 'application/json' })});
    }
    
    list(): Observable<Research[]> {
        return this._httpClient.post<Research[]>('https://localhost:44382/researches', {
            "Name": "",
            "GroupName":""
        }, {headers : new HttpHeaders({ 'Content-Type': 'application/json' })});
    }

    getRules(): Observable<Rule[]> {
        return this._httpClient.get<Rule[]>(this.serverApi);
    }
}
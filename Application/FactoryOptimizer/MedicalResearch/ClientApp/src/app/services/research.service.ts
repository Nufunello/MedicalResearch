import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Research } from "../models/research.model";
import { Rule } from "../models/rule.model";

@Injectable({
    providedIn: 'root',
})
export class ResearchService {
    constructor(private readonly _endpoint: string, private readonly _httpClient: HttpClient) {}

    create(entity: Research): Observable<Research> {
        return this._httpClient.post<Research>(this._endpoint, entity);
    }
    
    list(): Observable<Research[]> {
        return this._httpClient.get<Research[]>(this._endpoint);
    }

    getRules(): Observable<Rule[]> {
        return this._httpClient.get<Rule[]>(this._endpoint);
    }
}
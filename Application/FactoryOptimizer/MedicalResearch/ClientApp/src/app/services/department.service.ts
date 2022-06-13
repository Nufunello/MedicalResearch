import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Department } from "../models/department.model";
import { Research } from "../models/research.model";
import { Rule } from "../models/rule.model";

@Injectable()
export class DepartmentService {
    constructor(private readonly _httpClient: HttpClient) {}
    serverApi: 'http://localhost:44382'

    create(entity: Department): Observable<number> {
        return this._httpClient.post<number>('https://localhost:44382/department/new', entity, {headers : new HttpHeaders({ 'Content-Type': 'application/json' })});
    }

    update(entity: Department): Observable<number> {
        return this._httpClient.put<number>('https://localhost:44382/department/' + entity.Id, entity, {headers : new HttpHeaders({ 'Content-Type': 'application/json' })});
    }

    getOne(id: number): Observable<Department> {
        return this._httpClient.get<Department>('https://localhost:44382/department/' + id);
    }

    getDepartmentDetails(id: number): Observable<any> {
        return this._httpClient.get<any>('https://localhost:44382/department/' + id);
    }
    
    list(): Observable<Department[]> {
        return this._httpClient.get<Department[]>('https://localhost:44382/department', {headers : new HttpHeaders({ 'Content-Type': 'application/json' })});
    }

    getRules(): Observable<Rule[]> {
        return this._httpClient.get<Rule[]>(this.serverApi);
    }
}
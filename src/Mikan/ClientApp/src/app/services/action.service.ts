import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {Action} from '../models/action.model';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class ActionService {

  constructor(private http: HttpClient) {
  }

  findOne(id: number): Observable<Action> {
    return this.http.get<Action>(`api/action/${id}`);
  }

  findAll(): Observable<Action[]> {
    return this.http.get<Action[]>('api/action');
  }

  save(action: Action): Observable<Action> {
    return this.http.post<Action>(`api/action`, action);
  }

  delete(id: any) {
    return this.http.delete(`api/action`, id);
  }
}

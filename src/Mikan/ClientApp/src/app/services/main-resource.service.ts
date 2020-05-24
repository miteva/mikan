import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {Action} from '../models/action.model';
import {MainResource} from '../models/main-resource.model';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class MainResourceService {

  constructor(private http: HttpClient) {
  }

  findOne(id: number): Observable<MainResource> {
    return this.http.get<MainResource>(`api/main-resource/${id}`);
  }

  findAll(): Observable<MainResource[]> {
    return this.http.get<MainResource[]>('api/main-resource');
  }

  save(action: MainResource): Observable<MainResource> {
    return this.http.post<MainResource>('api/main-resource', action);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(`api/main-resource/${id}`);
  }
}

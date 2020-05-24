import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {Resource} from '../models/resource.model';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class ResourceService {

  constructor(private http: HttpClient) {
  }

  findOne(id: number): Observable<Resource> {
    return this.http.get<Resource>(`api/resource/${id}`);
  }

  findAll(): Observable<Resource[]> {
    return this.http.get<Resource[]>(`api/resource`);
  }

  save(resource: Resource): Observable<Resource> {
    return this.http.post<Resource>(`api/resource`, resource);
  }

  delete(id: any): Observable<any> {
    return this.http.delete(`api/resource/${id}`);
  }
}

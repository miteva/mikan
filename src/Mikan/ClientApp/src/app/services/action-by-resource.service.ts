import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {ResourceAction} from '../models/action-by-resource.model';
import {HttpClient} from '@angular/common/http';
import {Resource} from '../models/resource.model';

@Injectable()
export class ActionByResourceService {

  constructor(private http: HttpClient) {
  }

  findOne(id: number): Observable<ResourceAction> {
    return this.http.get<ResourceAction>(`api/resource-action/${id}`);
  }

  findAll(): Observable<ResourceAction[]> {
    return this.http.get<ResourceAction[]>('api/resource-action');
  }

  save(action: ResourceAction): Observable<ResourceAction> {
    return this.http.post<ResourceAction>('api/resource-action', action);
  }

  findAllByResource(resourceId: number): Observable<ResourceAction[]> {
    return this.http.get<ResourceAction[]>(`api/resource-action/resourceId/${resourceId}`);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(`api/resource-action/${id}`);
  }
}

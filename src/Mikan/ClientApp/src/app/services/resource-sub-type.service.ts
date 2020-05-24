import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {ResourceSubType} from '../models/resource-sub.type';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class ResourceSubTypeService {

  constructor(private http: HttpClient) {
  }

  findOne(id: number): Observable<ResourceSubType> {
    return this.http.get<ResourceSubType>(`api/resource-sub-type/${id}`);
  }

  findAll(): Observable<ResourceSubType[]> {
    return this.http.get<ResourceSubType[]>('api/resource-sub-type');
  }

  save(action: ResourceSubType): Observable<ResourceSubType> {
    return this.http.post<ResourceSubType>('api/resource-sub-type', action);
  }

}

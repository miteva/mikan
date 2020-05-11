import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {ResourceSubType} from '../models/resource-sub.type';

@Injectable()
export class ResourceSubTypeService {

  findOne(id: number): Observable<ResourceSubType> {
    return of(null);
  }

  findAll(): Observable<ResourceSubType[]> {
    return of([null]);
  }

  save(action: ResourceSubType) {
    // todo nate save
  }

}

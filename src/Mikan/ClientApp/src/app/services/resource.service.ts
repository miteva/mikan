import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {Resource} from '../models/resource.model';

@Injectable()
export class ResourceService {

  findOne(id: number): Observable<Resource> {
    return of(null);
  }

  findAll(): Observable<Resource[]> {
    return of([null]);
  }

  save(action: Resource) {
    // todo nate save
  }

  delete(id: any) {
    // todo nate
  }
}

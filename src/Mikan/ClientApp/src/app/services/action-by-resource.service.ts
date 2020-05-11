import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {ResourceAction} from '../models/action-by-resource.model';

@Injectable()
export class ActionByResourceService {

  findOne(id: number): Observable<ResourceAction> {
    return of(null);
  }

  findAll(): Observable<ResourceAction[]> {
    return of([null]);
  }

  save(action: ResourceAction) {
    // todo nate save
  }

  findAllByResource(resourceId: number): Observable<ResourceAction[]> {
    return of([null]);
  }

  delete(id: number) {
    // todo nate
  }
}

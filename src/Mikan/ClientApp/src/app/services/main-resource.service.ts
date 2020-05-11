import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {Action} from '../models/action.model';
import {MainResource} from '../models/main-resource.model';

@Injectable()
export class MainResourceService {

  findOne(id: number): Observable<MainResource> {
    return of(null);
  }

  findAll(): Observable<MainResource[]> {
    return of([null]);
  }

  save(action: MainResource) {
    // todo nate save
  }

  delete(id: number) {
    // todo nate
  }
}

import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {Action} from '../models/action.model';

@Injectable()
export class ActionService {

  findOne(id: number): Observable<Action> {
    return of(null);
  }

  findAll(): Observable<Action[]> {
    return of([null]);
  }

  save(action: Action) {
    // todo nate save
  }

}

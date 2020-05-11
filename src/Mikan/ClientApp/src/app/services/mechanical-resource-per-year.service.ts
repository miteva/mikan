import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {MechanicalResourcePerYear} from '../models/mechanical-resource-by-year.model';

@Injectable()
export class MechanicalResourcePerYearService {

  findAll(): Observable<MechanicalResourcePerYear[]> {
    return of([null]);
  }

  findOne(id: number): Observable<MechanicalResourcePerYear> {
    return of(null);
  }

  save(mechanicalServicePerYear: MechanicalResourcePerYear) {
    //todo nate
  }

  delete(id) {
    //todo nate
  }
}

import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {MechanicalResourcePerYear} from '../models/mechanical-resource-by-year.model';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class MechanicalResourcePerYearService {

  constructor(private http: HttpClient) {
  }

  findAll(): Observable<MechanicalResourcePerYear[]> {
    return this.http.get<MechanicalResourcePerYear[]>('api/mechanical-resource-per-year');
  }

  findOne(id: number): Observable<MechanicalResourcePerYear> {
    return this.http.get<MechanicalResourcePerYear>(`api/mechanical-resource-per-year/${id}`);
  }

  save(mechanicalServicePerYear: MechanicalResourcePerYear) {
    return this.http.post(`api/mechanical-resource-per-year`, mechanicalServicePerYear);
  }

  delete(id): Observable<any> {
    return this.http.delete(`api/mechanical-resource-per-year/${id}`);
  }
}

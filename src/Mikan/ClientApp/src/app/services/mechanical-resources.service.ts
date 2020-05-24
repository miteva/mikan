import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {MechanicalResources} from '../models/mechanical.resources';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class MechanicalResourcesService {

  constructor(private http: HttpClient) {
  }

  findAll(): Observable<MechanicalResources[]> {
    // const mechanicalResource = new MechanicalResources();
    // mechanicalResource.id = 1;
    // mechanicalResource.name = 'test name';
    // mechanicalResource.description = 'desc';
    return this.http.get<MechanicalResources[]>(`api/mechanical-resource`);
  }

  findOne(id: number): Observable<MechanicalResources> {
    // const mechanicalResource = new MechanicalResources();
    // mechanicalResource.id = 1;
    // mechanicalResource.name = 'test name';
    // mechanicalResource.description = 'desc';
    return this.http.get<MechanicalResources>(`api/mechanical-resource/${id}`);
  }

  save(mechanicalResource: MechanicalResources): Observable<MechanicalResources> {
    // const mechanicalResource1 = new MechanicalResources();
    // mechanicalResource1.id = 1;
    // mechanicalResource.name = 'test name';
    // mechanicalResource1.description = 'desc';
    return this.http.post<MechanicalResources>(`api/mechanical-resource`, mechanicalResource);
  }

  delete(id: any): Observable<any> {
    return this.http.delete(`api/mechanical-resource/${id}`);
  }
}

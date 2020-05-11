import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {MechanicalResources} from '../models/mechanical.resources';

@Injectable()
export class MechanicalResourcesService {

  findAll(): Observable<MechanicalResources[]> {
    const mechanicalResource = new MechanicalResources();
    mechanicalResource.id = 1;
    mechanicalResource.name = 'test name';
    mechanicalResource.description = 'desc';
    return of([mechanicalResource]);
  }

  findOne(id: number): Observable<MechanicalResources> {
    const mechanicalResource = new MechanicalResources();
    mechanicalResource.id = 1;
    mechanicalResource.name = 'test name';
    mechanicalResource.description = 'desc';
    return of(mechanicalResource);
  }

  save(mechanicalResource: MechanicalResources) {
    const mechanicalResource1 = new MechanicalResources();
    mechanicalResource1.id = 1;
    mechanicalResource.name = 'test name';
    mechanicalResource1.description = 'desc';
    return of(mechanicalResource1);
  }

  delete(id: any) {
    // todo delete
  }
}

import {Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {MechanicalResourcesModel} from '../models/mechanical-resources.model';

@Injectable()
export class MechanicalResourcesService {

  findAll(): Observable<MechanicalResourcesModel[]> {
    const mechanicalResource = new MechanicalResourcesModel();
    mechanicalResource.id = 1;
    mechanicalResource.name = 'test name';
    mechanicalResource.description = 'desc';
    return of([mechanicalResource]);
  }

  findOne(id:number): Observable<MechanicalResourcesModel> {
    const mechanicalResource = new MechanicalResourcesModel();
    mechanicalResource.id = 1;
    mechanicalResource.name = 'test name';
    mechanicalResource.description = 'desc';
    return of(mechanicalResource);
  }

  update(mechanicalResource: MechanicalResourcesModel) {
    const mechanicalResource1 = new MechanicalResourcesModel();
    mechanicalResource1.id = 1;
    mechanicalResource.name = 'test name';
    mechanicalResource1.description = 'desc';
    return of(mechanicalResource1);
  }

  delete(id: any) {
    // todo delete
  }
}

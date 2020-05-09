// osnovni sredstva po godina
import {MechanicalResourcesModel} from './mechanical-resources.model';

export class MechanicalResourceByYearModel {
  id: number;
  mechanicalResource: MechanicalResourcesModel;
  year: number;
  amortization: number; // percenatage
  value: number;
  status: string;
  description: string;
}

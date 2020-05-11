// osnovni sredstva po godina
import {MechanicalResources} from './mechanical.resources';

export class MechanicalResourcePerYear {
  id: number;
  mechanicalResource: MechanicalResources;
  year: number;
  amortization: number; // percenatage
  value: number;
  description: string;
}

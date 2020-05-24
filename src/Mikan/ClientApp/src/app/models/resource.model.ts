import {MainResource} from './main-resource.model';
import {ResourceSubType} from './resource-sub.type';

export class Resource {
  id: number;
  name: string;
  mainResource: MainResource;
  description: string;
  size: number;
  resourceSubType: ResourceSubType;
  year: number;

}

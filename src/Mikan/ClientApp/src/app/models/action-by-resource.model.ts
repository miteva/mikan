import {Action} from './action.model';
import {Resource} from './resource.model';

export class ResourceAction {
  id: number;
  action: Action;
  description: string;
  date: any;
  expenses: number;
  revenue: number;
  produced: number;
  sold: number;
  resource: Resource;
}

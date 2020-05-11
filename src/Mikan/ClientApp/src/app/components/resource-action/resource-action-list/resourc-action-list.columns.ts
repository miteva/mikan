import {Action} from '../../../models/action.model';
import {Resource} from '../../../models/resource.model';

const resourceActionColumns: Array<any> = [
  {
    name: 'action.name',
    label: 'Акција'
  },
  {
    name: 'resource.name',
    label: 'Нива'
  },
  {
    name: 'description',
    label: 'Опис'
  },
  {
    name: 'date',
    label: 'Датум'
  },
  {
    name: 'expenses',
    label: 'Трошоци'
  },
  {
    name: 'revenue',
    label: 'Добивка'
  },
  {
    name: 'produced',
    label: 'Произведено'
  },
  {
    name: 'sold',
    label: 'Продадено'
  }
];

export default resourceActionColumns;

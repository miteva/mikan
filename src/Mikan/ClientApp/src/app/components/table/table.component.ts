import {Component, EventEmitter, Input, Output} from '@angular/core';
import {ReplaySubject, Subject} from 'rxjs';

@Component({
  selector: 'mk-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.scss']
})
export class TableComponent {
  @Input() data;
  @Input() columns;
  @Input() shouldEdit = true;
  @Input() shouldDelete = true;

  @Output() onEdit: EventEmitter<any> = new EventEmitter();
  @Output() onDelete: EventEmitter<any> = new EventEmitter();

  edit(row) {
    this.onEdit.emit(row);
  }

  delete(row) {
    this.onDelete.emit(row);
  }
}

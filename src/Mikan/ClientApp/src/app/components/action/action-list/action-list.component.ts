import {Component, OnInit} from '@angular/core';
import {ActionService} from '../../../services/action.service';
import {ActivatedRoute, Router} from '@angular/router';
import {Observable} from 'rxjs';
import {Action} from '../../../models/action.model';
import actionColumn from './action-columns';

@Component({
  templateUrl: './action-list.component.html'
})
export class ActionListComponent implements OnInit {

  actions$: Observable<Action[]>;
  columns = actionColumn;

  constructor(private _service: ActionService,
    private _router: Router,
    private _route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.actions$ = this._service.findAll();
  }

  add() {
    this._router.navigate([':id'], {relativeTo: this._route});
  }
}

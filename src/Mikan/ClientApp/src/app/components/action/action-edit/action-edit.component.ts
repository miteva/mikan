import {Component, OnInit} from '@angular/core';
import {ActionService} from '../../../services/action.service';
import {ActivatedRoute, Router} from '@angular/router';
import {Action} from '../../../models/action.model';

@Component({
  templateUrl: './action-edit.component.html'
})
export class ActionEditComponent implements OnInit {

  action: Action;

  constructor(private _service: ActionService,
    private _router: Router,
    private _route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this._route.params.subscribe(parmas => {
      const id = +parmas['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => this.action = response);
      } else {
        this.action = new Action();
      }
    });
  }

  save() {
    this._service.save(this.action).subscribe(response => {
      this._router.navigate(['action']);
    });
  }
}

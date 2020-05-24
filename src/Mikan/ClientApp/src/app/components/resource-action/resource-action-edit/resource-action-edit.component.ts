import {Component, OnInit} from '@angular/core';
import {ActionByResourceService} from '../../../services/action-by-resource.service';
import {ActivatedRoute, Router} from '@angular/router';
import {ResourceAction} from '../../../models/action-by-resource.model';
import {Observable} from 'rxjs';
import {Resource} from '../../../models/resource.model';
import {ResourceService} from '../../../services/resource.service';
import {Action} from '../../../models/action.model';
import {ActionService} from '../../../services/action.service';

@Component({
  templateUrl: './resource-action-edit.component.html'
})
export class ResourceActionEditComponent implements OnInit {

  resourceAction: ResourceAction;
  resources$: Observable<Resource[]>;
  actions$: Observable<Action[]>;

  constructor(private _service: ActionByResourceService,
    private resourceService: ResourceService,
    private _actionService: ActionService,
    private _router: Router,
    private _route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this._route.params.subscribe(parmas => {
      const id = +parmas['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => this.resourceAction = response);
      } else {
        this.resourceAction = new ResourceAction();
      }
    });

    this.resources$ = this.resourceService.findAll();
    this.actions$ = this._actionService.findAll();
  }

  save() {
    this._service.save(this.resourceAction).subscribe(response => {
      this._router.navigate(['resource-action']);
    });
  }

  updateResource(resource: Resource) {
    this.resourceAction.resource = resource;
  }

  updateAction(action: Action) {
    this.resourceAction.action = action;
  }
}

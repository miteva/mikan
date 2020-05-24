import {Component, OnInit} from '@angular/core';
import {ActionByResourceService} from '../../../services/action-by-resource.service';
import {ActivatedRoute, Router} from '@angular/router';
import {Observable} from 'rxjs';
import {ResourceAction} from '../../../models/action-by-resource.model';
import resourceActionColumns from './resource-action-list.columns';
import {Resource} from '../../../models/resource.model';
import {ResourceService} from '../../../services/resource.service';

@Component({
  templateUrl: './resource-action-list.component.html'
})
export class ResourceActionListComponent implements OnInit {

  resourceActions$: Observable<ResourceAction[]>;
  resources$: Observable<Resource[]>;
  columns = resourceActionColumns;

  constructor(private _service: ActionByResourceService,
    private _router: Router,
    private _route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.resourceActions$ = this._service.findAll();
  }

  filter(resource: Resource) {
    this.resourceActions$ = this._service.findAllByResource(resource.id);
  }

  add() {
    this._router.navigate(['new'], {relativeTo: this._route});
  }

  delete(resourceAction: ResourceAction) {
    this._service.delete(resourceAction.id).subscribe();
  }

  edit(resourceAction: ResourceAction) {
    this._router.navigate([resourceAction.id], {relativeTo: this._route});
  }
}

import {Component, OnInit} from '@angular/core';
import {Observable} from 'rxjs';
import {ResourceSubType} from '../../../models/resource-sub.type';
import {ResourceSubTypeService} from '../../../services/resource-sub-type.service';
import {ActivatedRoute, Router} from '@angular/router';
import resourceSubTypeColumns from './resource-sub-type-columns';

@Component({
  templateUrl: './resource-sub-type-list.component.html'
})
export class ResourceSubTypeListComponent implements OnInit {

  resourceSubType$: Observable<ResourceSubType[]>;
  columns = resourceSubTypeColumns;

  constructor(private _service: ResourceSubTypeService,
    private _router: Router,
    private _route: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.resourceSubType$ = this._service.findAll();
  }

  add() {
    this._router.navigate(['new'], {relativeTo: this._route});
  }
}

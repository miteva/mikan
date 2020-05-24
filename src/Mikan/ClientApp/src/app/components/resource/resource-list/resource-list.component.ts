import {Component, OnInit} from '@angular/core';
import {ResourceService} from '../../../services/resource.service';
import {Observable} from 'rxjs';
import {Resource} from '../../../models/resource.model';
import {ActivatedRoute, Router} from '@angular/router';
import resourceColumns from './resource-list.columns';

@Component({
  templateUrl: './resource-list.component.html'
})
export class ResourceListComponent implements OnInit {

  resources$: Observable<Resource[]>;
  columns = resourceColumns;

  constructor(private _service: ResourceService,
    private _router: Router,
    private _route: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.resources$ = this._service.findAll();
  }

  add() {
    this._router.navigate(['new'], {relativeTo: this._route});
  }

  delete(row: any) {
    this._service.delete(row.id).subscribe(response =>
      this._router.navigate(['resource']));
  }

  edit(row) {
    this._router.navigate([row.id], {relativeTo: this._route});
  }
}

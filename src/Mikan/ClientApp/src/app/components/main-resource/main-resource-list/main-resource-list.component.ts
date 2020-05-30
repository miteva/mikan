import {Component, OnInit} from '@angular/core';
import {MainResourceService} from '../../../services/main-resource.service';
import {Observable} from 'rxjs';
import {MainResource} from '../../../models/main-resource.model';
import mainResourceListColumns from './main-resource-list.columns';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  templateUrl: './main-resource-list.component.html'
})
export class MainResourceListComponent implements OnInit {

  mainResources$: Observable<MainResource[]>;

  columns = mainResourceListColumns;

  ngOnInit(): void {
    this.mainResources$ = this._service.findAll();
  }

  constructor(private _service: MainResourceService,
    private _router: Router,
    private _route: ActivatedRoute) {

  }

  new() {
    this._router.navigate(['new'], {relativeTo: this._route});
  }

  delete(row: MainResource) {
    this._service.delete(row.id).subscribe();
  }

  edit(row: MainResource) {
    this._router.navigate([`${row.id}`], {relativeTo: this._route});
  }
}

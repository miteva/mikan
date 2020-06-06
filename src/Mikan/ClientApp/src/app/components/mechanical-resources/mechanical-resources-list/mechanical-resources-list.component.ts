import {Component, OnInit} from '@angular/core';
import {MechanicalResourcesService} from '../../../services/mechanical-resources.service';
import {Observable} from 'rxjs';
import {MechanicalResources} from '../../../models/mechanical.resources';
import {ActivatedRoute, Router} from '@angular/router';
import mechanicalResourceColumn from './mechanical-resource.column';

@Component({
  selector: 'mechanical-resources-list',
  templateUrl: './mechanical-resources-list.component.html',
  styleUrls: ['./mechanical-resources-list.component.scss']
})
export class MechanicalResourcesListComponent implements OnInit {

  mechanicalResources$: Observable<MechanicalResources[]>;
  mechanicalResourceColumn = mechanicalResourceColumn;

  constructor(private _service: MechanicalResourcesService,
    private _router: Router,
    private _route: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.mechanicalResources$ = this._service.findAll();
  }

  edit(row: any) {
    this._router.navigate([`mechanical-resources/${row.id}`]);
  }

  delete(row: any) {
    this._service.delete(row.id).subscribe();
  }

  new() {
    this._router.navigate(['new'], {relativeTo: this._route});
  }

}

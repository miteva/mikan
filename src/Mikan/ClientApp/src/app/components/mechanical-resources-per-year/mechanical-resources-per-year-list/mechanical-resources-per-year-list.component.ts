import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {Observable} from 'rxjs';
import {MechanicalResourcePerYear} from '../../../models/mechanical-resource-by-year.model';
import {MechanicalResourcePerYearService} from '../../../services/mechanical-resource-per-year.service';
import mechanicalResourcePerYearColumns from './mechanical-resources-per-year-list.columns';

@Component({
  selector: 'mechanical-resources-per-year-list',
  templateUrl: './mechanical-resources-per-year-list.component.html'
})
export class MechanicalResourcesPerYearListComponent implements OnInit {

  mechanicalResourcesPerYear$: Observable<MechanicalResourcePerYear[]>;
  columns = mechanicalResourcePerYearColumns;

  constructor(private _service: MechanicalResourcePerYearService,
    private _router: Router,
    private _route: ActivatedRoute) {
  }

  add() {
    this._router.navigate(['new'], {relativeTo: this._route});

  }

  ngOnInit(): void {
    this.mechanicalResourcesPerYear$ = this._service.findAll();
  }

  delete(row: MechanicalResourcePerYear) {
    this._service.delete(row.id).subscribe();
  }

  edit(row: MechanicalResourcePerYear) {
    this._router.navigate([row.id], {relativeTo: this._route});
  }
}

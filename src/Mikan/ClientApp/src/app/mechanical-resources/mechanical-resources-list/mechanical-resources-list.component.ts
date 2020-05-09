import {Component, OnInit} from '@angular/core';
import {MechanicalResourcesService} from '../mechanical-resources.service';
import {Observable} from 'rxjs';
import {MechanicalResourcesModel} from '../../models/mechanical-resources.model';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'mechanical-resources-list',
  templateUrl: './mechanical-resources-list.component.html',
  styleUrls: ['./mechanical-resources-list.component.scss']
})
export class MechanicalResourcesListComponent implements OnInit {

  mechanicalResources$: Observable<MechanicalResourcesModel[]>;

  constructor(private _service: MechanicalResourcesService,
    private _router: Router,
    private _route: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.mechanicalResources$ = this._service.findAll();
  }

  openDetails(id: any) {
    this._router.navigate([`mechanical-resources/${id}`]);
  }

  delete(id: any) {
    this._service.delete(id);
  }

  new() {
    this._router.navigate(['new'], {relativeTo: this._route});

  }
}

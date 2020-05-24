import {MechanicalResourcesService} from '../../../services/mechanical-resources.service';
import {Observable} from 'rxjs';
import {MechanicalResources} from '../../../models/mechanical.resources';
import {MechanicalResourcePerYear} from '../../../models/mechanical-resource-by-year.model';
import {ActivatedRoute, Router} from '@angular/router';
import {MechanicalResourcePerYearService} from '../../../services/mechanical-resource-per-year.service';
import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'mechanical-resources-per-year-edit',
  templateUrl: './mechanical-resources-per-year-edit.component.html',
  styleUrls:['./mechanical-resources-per-year-edit.component.scss']
})
export class MechanicalResourcesPerYearEditComponent implements OnInit {

  mechanicalResourcePerYear: MechanicalResourcePerYear;
  mechanicalResources$: Observable<MechanicalResources[]>;

  constructor(
    private _mechanicalResourceService: MechanicalResourcesService,
    private _route: ActivatedRoute,
    private _router: Router,
    private _service: MechanicalResourcePerYearService) {

  }

  ngOnInit(): void {
    this._route.params.subscribe(params => {
      const id = +params['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => this.mechanicalResourcePerYear = response);
      } else {
        this.mechanicalResourcePerYear = new MechanicalResourcePerYear();
      }
    });
    this.mechanicalResources$ = this._mechanicalResourceService.findAll();
  }

  updateSelection(value) {
    this.mechanicalResourcePerYear.mechanicalResource = value;
  }

  save() {
    this._router.navigate(['mechanical-resources-per-year']);
  }
}

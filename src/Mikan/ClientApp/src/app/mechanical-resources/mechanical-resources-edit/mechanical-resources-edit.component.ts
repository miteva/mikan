import {Component, OnInit} from '@angular/core';
import {MechanicalResourcesService} from '../mechanical-resources.service';
import {MechanicalResourcesModel} from '../../models/mechanical-resources.model';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'mechanical-resources-edit',
  templateUrl: './mechanical-resources-edit.component.html'
})
export class MechanicalResourcesEditComponent implements OnInit {

  mechanicalResource: MechanicalResourcesModel;

  constructor(private _service: MechanicalResourcesService,
    private _route: ActivatedRoute,
    private _router: Router) {

  }

  ngOnInit(): void {
    this._route.params.subscribe(params => {
      const id = +params['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => {
          this.mechanicalResource = response;
        });
      } else {
        this.mechanicalResource = new MechanicalResourcesModel();
      }
    });
  }

  save() {
    this._service.update(this.mechanicalResource).subscribe(response => {
      this._router.navigate(['mechanical-resources']);
    });
  }
}

import {Component, OnInit} from '@angular/core';
import {MechanicalResourcesService} from '../../../services/mechanical-resources.service';
import {MechanicalResources} from '../../../models/mechanical.resources';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'mechanical-resources-edit',
  templateUrl: './mechanical-resources-edit.component.html',
  styleUrls:['./mechanical-resources-edit.component.scss']
})
export class MechanicalResourcesEditComponent implements OnInit {

  mechanicalResource: MechanicalResources = new MechanicalResources();

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
      } 
    });
  }

  save() {
    this._service.save(this.mechanicalResource).subscribe(response => {
      this._router.navigate(['mechanical-resources']);
    });
  }
}

import {Component, OnInit} from '@angular/core';
import {ResourceSubType} from '../../../models/resource-sub.type';
import {ResourceSubTypeService} from '../../../services/resource-sub-type.service';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  templateUrl: './resource-sub-type-edit.component.html'
})
export class ResourceSubTypeEditComponent implements OnInit {

  resourceSubType: ResourceSubType;

  constructor(private _service: ResourceSubTypeService,
    private _router: Router,
    private _route: ActivatedRoute) {

  }

  ngOnInit(): void {
    this._route.params.subscribe(params => {
      const id = +params['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => this.resourceSubType = response);
      } else {
        this.resourceSubType = new ResourceSubType();
      }
    });
  }

  save() {
    this._service.save(this.resourceSubType).subscribe(response => {
      this._router.navigate(['resource-sub-type']);
    });
  }

}

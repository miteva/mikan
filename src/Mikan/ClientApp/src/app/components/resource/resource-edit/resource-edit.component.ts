import {Component, OnInit} from '@angular/core';
import {Resource} from '../../../models/resource.model';
import {ResourceService} from '../../../services/resource.service';
import {ActivatedRoute, Router} from '@angular/router';
import {Observable} from 'rxjs';
import {MainResource} from '../../../models/main-resource.model';
import {ResourceSubType} from '../../../models/resource-sub.type';
import {MainResourceService} from '../../../services/main-resource.service';
import {ResourceSubTypeService} from '../../../services/resource-sub-type.service';

@Component({
  templateUrl: './resource-edit.component.html'
})
export class ResourceEditComponent implements OnInit {

  resource: Resource;
  mainResources$: Observable<MainResource[]>;
  resourceSubTypes$: Observable<ResourceSubType[]>;

  constructor(private _service: ResourceService,
    private _router: Router,
    private _route: ActivatedRoute,
    private _mainResourceService: MainResourceService,
    private _resourceSubTypeService: ResourceSubTypeService) {

  }

  ngOnInit(): void {
    this._route.params.subscribe(params => {
      const id = +params['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => this.resource = response);
      } else {
        this.resource = new Resource();
      }
    });

    this.mainResources$ = this._mainResourceService.findAll();
    this.resourceSubTypes$ = this._resourceSubTypeService.findAll();
  }

  save() {
    this._service.save(this.resource).subscribe(response => {
      this._router.navigate(['resource']);
    });
  }

  updateSelection(mainResource: MainResource) {
    this.resource.mainResource = mainResource;
  }

  updateType(type: ResourceSubType) {
    this.resource.resourceSubType = type;
  }
}

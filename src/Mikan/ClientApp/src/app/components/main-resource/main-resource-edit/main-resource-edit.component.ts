import {Component, OnInit} from '@angular/core';
import {MainResourceService} from '../../../services/main-resource.service';
import {ActivatedRoute, Router} from '@angular/router';
import {MainResource} from '../../../models/main-resource.model';
import {main} from '@angular/compiler-cli/src/main';

@Component({
  templateUrl: './main-resource-edit.component.html'
})
export class MainResourceEditComponent implements OnInit {

  mainResource: MainResource;

  constructor(private _service: MainResourceService,
    private _route: ActivatedRoute,
    private _router: Router) {

  }

  ngOnInit(): void {
    this._route.params.subscribe(params => {
      const id = +params['id'];
      if (id) {
        this._service.findOne(id).subscribe(response => this.mainResource = response);
      } else {
        this.mainResource = new MainResource();
      }
    });

  }

  save() {
    this._service.save(this.mainResource).subscribe(response => {
      this._router.navigate(['main-resource']);
    });
  }
}

import {Router} from '@angular/router';
import {Component} from '@angular/core';

@Component({
  templateUrl: './home-page.page.html'
})
export class HomePagePage {

  constructor(private _router: Router) {

  }

  onMechanicalResourcesClick() {
    this._router.navigate(['/mechanical-resources']);
  }
}

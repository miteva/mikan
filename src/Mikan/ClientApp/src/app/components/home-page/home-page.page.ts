import {Router} from '@angular/router';
import {Component} from '@angular/core';

@Component({
  templateUrl: './home-page.page.html'
})
export class HomePagePage {

  constructor(private _router: Router) {

  }

  onClick(route: string) {
    this._router.navigate([route]);
  }
}

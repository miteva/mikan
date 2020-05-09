import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {NavMenuComponent} from './nav-menu/nav-menu.component';
import {HomeComponent} from './home/home.component';
import {CounterComponent} from './counter/counter.component';
import {FetchDataComponent} from './fetch-data/fetch-data.component';
import {MachineComponent} from './machine/machine.component';
import {AddMachineComponent} from './add-machine/add-machine.component';
import {MechanicalResourcesListComponent} from './mechanical-resources/mechanical-resources-list/mechanical-resources-list.component';
import {MechanicalResourcesService} from './mechanical-resources/mechanical-resources.service';
import {MechanicalResourcesEditComponent} from './mechanical-resources/mechanical-resources-edit/mechanical-resources-edit.component';
import {HomePagePage} from './home-page/home-page.page';

const components = [
  MechanicalResourcesListComponent,
  MechanicalResourcesEditComponent
];

const services = [
  MechanicalResourcesService
];

const pages = [
  HomePagePage
];

@NgModule({
  declarations: [
    ...components,
    ...pages,
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MachineComponent,
    AddMachineComponent
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path: '', component: HomePagePage, pathMatch: 'full'},
      {path: 'mechanical-resources', component: MechanicalResourcesListComponent, pathMatch: 'full'},
      {path: 'mechanical-resources/new', component: MechanicalResourcesEditComponent},
      {path: 'mechanical-resources/:id', component: MechanicalResourcesEditComponent},
      // { path: '', component: HomeComponent, pathMatch: 'full' },
      {path: 'counter', component: CounterComponent},
      {path: 'fetch-data', component: FetchDataComponent},
      {path: 'machine', component: MachineComponent},
      {path: 'add-machine', component: AddMachineComponent}
    ])
  ],
  providers: [...services],
  bootstrap: [AppComponent]
})
export class AppModule {
}

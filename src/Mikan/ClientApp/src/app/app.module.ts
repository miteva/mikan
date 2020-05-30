import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {NavMenuComponent} from './nav-menu/nav-menu.component';
import {HomeComponent} from './home/home.component';
import {CounterComponent} from './counter/counter.component';
import {MechanicalResourcesListComponent} from './components/mechanical-resources/mechanical-resources-list/mechanical-resources-list.component';
import {MechanicalResourcesService} from './services/mechanical-resources.service';
import {MechanicalResourcesEditComponent} from './components/mechanical-resources/mechanical-resources-edit/mechanical-resources-edit.component';
import {HomePagePage} from './components/home-page/home-page.page';
import {routing} from './app.module.routing';
import {MechanicalResourcesPerYearListComponent} from './components/mechanical-resources-per-year/mechanical-resources-per-year-list/mechanical-resources-per-year-list.component';
import {MechanicalResourcesPerYearEditComponent} from './components/mechanical-resources-per-year/mechanical-resources-per-year-edit/mechanical-resources-per-year-edit.component';
import {MatFormFieldModule, MatInputModule, MatSelectModule} from '@angular/material';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MechanicalResourcePerYearService} from './services/mechanical-resource-per-year.service';
import {TableComponent} from './components/table/table.component';
import {MainResourceListComponent} from './components/main-resource/main-resource-list/main-resource-list.component';
import {MainResourceEditComponent} from './components/main-resource/main-resource-edit/main-resource-edit.component';
import {MainResourceService} from './services/main-resource.service';
import {ActionService} from './services/action.service';
import {ActionByResourceService} from './services/action-by-resource.service';
import {ResourceService} from './services/resource.service';
import {ResourceSubTypeService} from './services/resource-sub-type.service';
import {ResourceSubTypeListComponent} from './components/resource-sub-type/resource-sub-type-list/resource-sub-type-list.component';
import {ResourceSubTypeEditComponent} from './components/resource-sub-type/resource-sub-type-edit/resource-sub-type-edit.component';
import {ResourceListComponent} from './components/resource/resource-list/resource-list.component';
import {ResourceEditComponent} from './components/resource/resource-edit/resource-edit.component';
import {ActionEditComponent} from './components/action/action-edit/action-edit.component';
import {ActionListComponent} from './components/action/action-list/action-list.component';
import {ResourceActionEditComponent} from './components/resource-action/resource-action-edit/resource-action-edit.component';
import {ResourceActionListComponent} from './components/resource-action/resource-action-list/resource-action-list.component';

const components = [
  MechanicalResourcesListComponent,
  MechanicalResourcesEditComponent,
  MechanicalResourcesPerYearListComponent,
  MechanicalResourcesPerYearEditComponent,
  TableComponent,
  MainResourceListComponent,
  MainResourceEditComponent,
  ResourceSubTypeListComponent,
  ResourceSubTypeEditComponent,
  ResourceListComponent,
  ResourceEditComponent,
  ActionEditComponent,
  ActionListComponent,
  ResourceActionEditComponent,
  ResourceActionListComponent

];

const services = [
  MechanicalResourcesService,
  MechanicalResourcePerYearService,
  MainResourceService,
  ActionService,
  ActionByResourceService,
  ResourceService,
  ResourceSubTypeService
];

const pages = [
  HomePagePage
];

const modules = [
  routing
];

@NgModule({
  declarations: [
    ...components,
    ...pages,
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    ...modules,
    RouterModule.forRoot([
      {path: 'counter', component: CounterComponent}
    ]),
    MatFormFieldModule,
    MatSelectModule,
    BrowserAnimationsModule,
    MatInputModule
  ],
  providers: [...services],
  bootstrap: [AppComponent]
})
export class AppModule {
}

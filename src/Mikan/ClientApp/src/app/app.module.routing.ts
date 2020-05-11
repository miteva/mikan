import {RouterModule, Routes} from '@angular/router';
import {ModuleWithProviders} from '@angular/core';
import {HomePagePage} from './components/home-page/home-page.page';
import {MechanicalResourcesListComponent} from './components/mechanical-resources/mechanical-resources-list/mechanical-resources-list.component';
import {MechanicalResourcesEditComponent} from './components/mechanical-resources/mechanical-resources-edit/mechanical-resources-edit.component';
import {MechanicalResourcesPerYearListComponent} from './components/mechanical-resources-per-year/mechanical-resources-per-year-list/mechanical-resources-per-year-list.component';
import {MechanicalResourcesPerYearEditComponent} from './components/mechanical-resources-per-year/mechanical-resources-per-year-edit/mechanical-resources-per-year-edit.component';
import {MainResourceListComponent} from './components/main-resource/main-resource-list/main-resource-list.component';
import {MainResourceEditComponent} from './components/main-resource/main-resource-edit/main-resource-edit.component';
import {ResourceSubTypeListComponent} from './components/resource-sub-type/resource-sub-type-list/resource-sub-type-list.component';
import {ResourceSubTypeEditComponent} from './components/resource-sub-type/resource-sub-type-edit/resource-sub-type-edit.component';
import {ActionListComponent} from './components/action/action-list/action-list.component';
import {ActionEditComponent} from './components/action/action-edit/action-edit.component';
import {ResourceActionListComponent} from './components/resource-action/resource-action-list/resource-action-list.component';
import {ResourceActionEditComponent} from './components/resource-action/resource-action-edit/resource-action-edit.component';

const appRoutes: Routes = [
  {
    path: '',
    component: HomePagePage, pathMatch: 'full'
  },
  {
    path: 'mechanical-resources',
    children: [
      {
        path: '',
        component: MechanicalResourcesListComponent,
      },
      {
        path: 'new',
        component: MechanicalResourcesEditComponent,
        pathMatch: 'full'
      },
      {
        path: ':id',
        component: MechanicalResourcesEditComponent,
        pathMatch: 'full'
      }
    ]
  },
  {
    path: 'mechanical-resources-per-year',
    children: [
      {
        path: '',
        component: MechanicalResourcesPerYearListComponent
      },
      {
        path: 'new',
        component: MechanicalResourcesPerYearEditComponent
      },
      {
        path: ':id',
        component: MechanicalResourcesPerYearEditComponent
      }
    ]
  },
  {
    path: 'main-resource',
    children: [
      {
        path: '',
        component: MainResourceListComponent
      },
      {
        path: 'new',
        component: MainResourceEditComponent
      },
      {
        path: ':id',
        component: MainResourceEditComponent
      }
    ]
  },
  {
    path: 'resource-sub-type',
    children: [
      {
        path: '',
        component: ResourceSubTypeListComponent
      },
      {
        path: 'new',
        component: ResourceSubTypeEditComponent
      },
      {
        path: ':id',
        component: ResourceSubTypeEditComponent
      }
    ]
  },
  {
    path: 'action',
    children: [
      {
        path: '',
        component: ActionListComponent
      },
      {
        path: 'new',
        component: ActionEditComponent
      },
      {
        path: ':id',
        component: ActionEditComponent
      }
    ]
  },
  {
    path: 'resource-action',
    children: [
      {
        path: '',
        component: ResourceActionListComponent
      },
      {
        path: 'new',
        component: ResourceActionEditComponent
      },
      {
        path: ':id',
        component: ResourceActionEditComponent
      }
    ]
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);

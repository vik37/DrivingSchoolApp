import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { CategoryAComponent } from './components/category-a/category-a.component';
import { CategoryABycityComponent } from './components/category-a-bycity/category-a-bycity.component';
import { CategoryCardComponent } from '../shared/components/category-card/category-card.component';
import {route} from 'src/app/categories/category-a/route';


@NgModule({
  declarations: [
    CategoryAComponent,
    CategoryABycityComponent,
    CategoryCardComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    RouterModule.forChild(route)
  ]
})
export class CategoryAModule { }

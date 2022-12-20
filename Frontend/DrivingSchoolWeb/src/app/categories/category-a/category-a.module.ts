import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoryAComponent } from './components/category-a/category-a.component';
import { CategoryABycityComponent } from './components/category-a-bycity/category-a-bycity.component';
import {route} from 'src/app/categories/category-a/route';


@NgModule({
  declarations: [
    CategoryAComponent,
    CategoryABycityComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(route)
  ]
})
export class CategoryAModule { }

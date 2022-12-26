import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoryAComponent } from './components/category-a/category-a.component';
import { CategoryAByCityComponent } from './components/category-a-by-city/category-a-by-city.component';
import {route} from 'src/app/categories/category-a/route';
import {CategoriesModule} from 'src/app/categories/categories.module';


@NgModule({
  declarations: [
    CategoryAComponent,
    CategoryAByCityComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryAComponent
  ]
})
export class CategoryAModule { }

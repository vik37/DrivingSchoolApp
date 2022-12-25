import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoryBComponent } from './components/category-b/category-b.component';
import { CategoryBByCityComponent } from './components/category-b-by-city/category-b-by-city.component';
import {route} from 'src/app/categories/category-b/route';
import {CategoriesModule} from 'src/app/categories/categories.module';

@NgModule({
  declarations: [
    CategoryBComponent,
    CategoryBByCityComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryBComponent
  ]
})
export class CategoryBModule { }

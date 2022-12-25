import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoryCComponent } from './components/category-c/category-c.component';
import { CategoryCByCityComponent } from './components/category-c-by-city/category-c-by-city.component';
import { InstructorComponent } from './components/instructor/instructor.component';
import {route} from 'src/app/categories/category-c/route';
import {CategoriesModule} from 'src/app/categories/categories.module';

@NgModule({
  declarations: [
    CategoryCComponent,
    CategoryCByCityComponent,
    InstructorComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryCComponent
  ]
})
export class CategoryCModule { }

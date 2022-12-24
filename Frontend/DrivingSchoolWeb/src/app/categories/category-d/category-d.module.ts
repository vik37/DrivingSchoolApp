import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoryDComponent } from './components/category-d/category-d.component';
import { CategoryDByCityComponent } from './components/category-d-by-city/category-d-by-city.component';
import { InstructorComponent } from './components/instructor/instructor.component';
import {route} from 'src/app/categories/category-d/route';
import {CategoriesModule} from 'src/app/categories/categories.module';

@NgModule({
  declarations: [
    CategoryDComponent,
    CategoryDByCityComponent,
    InstructorComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    RouterModule.forChild(route)
  ]
})
export class CategoryDModule { }

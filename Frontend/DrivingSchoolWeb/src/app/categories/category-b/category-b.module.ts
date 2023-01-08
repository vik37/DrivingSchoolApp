import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CategoryBComponent } from './components/category-b/category-b.component';
import { CategoryBByCityComponent } from './components/category-b-by-city/category-b-by-city.component';
import {route} from 'src/app/categories/category-b/route';
import {CategoriesModule} from 'src/app/categories/categories.module';
import { InstructorComponent } from './components/instructor/instructor.component';
import { CarComponent } from './components/car/car.component';
import { CarDetailComponent } from './components/car-detail/car-detail.component';

@NgModule({
  declarations: [
    CategoryBComponent,
    CategoryBByCityComponent,
    InstructorComponent,
    CarComponent,
    CarDetailComponent
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

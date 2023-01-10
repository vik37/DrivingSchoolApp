import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {route} from 'src/app/categories/category-b/route';
import {CategoriesModule} from 'src/app/categories/categories.module';
import {SharedModule} from 'src/app/shared/shared.module';
import {CategoryBComponent} from 'src/app/categories/category-b/components/category-b/category-b.component';
import {CategoryBByCityComponent} from './components/category-b-by-city/category-b-by-city.component';
import {InstructorComponent} from 'src/app/categories/category-b/components/instructor/instructor.component';
import {CarComponent} from 'src/app/categories/category-b/components/car/car.component';
import {CarDetailComponent} from 'src/app/categories/category-b/components/car-detail/car-detail.component';

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
    FontAwesomeModule,
    SharedModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryBComponent
  ]
})
export class CategoryBModule { }

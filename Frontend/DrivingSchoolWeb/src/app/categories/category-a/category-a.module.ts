import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CategoryAComponent } from './components/category-a/category-a.component';
import { CategoryAByCityComponent } from './components/category-a-by-city/category-a-by-city.component';
import {route} from 'src/app/categories/category-a/route';
import {CategoriesModule} from 'src/app/categories/categories.module';
import { MotorcycleComponent } from './components/motorcycle/motorcycle.component';
import { InstructorComponent } from './components/instructor/instructor.component';


@NgModule({
  declarations: [
    CategoryAComponent,
    CategoryAByCityComponent,
    MotorcycleComponent,
    InstructorComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    FontAwesomeModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryAComponent
  ]
})
export class CategoryAModule { }

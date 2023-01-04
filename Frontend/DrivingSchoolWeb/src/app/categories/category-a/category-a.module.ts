import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CategoryAComponent } from './components/category-a/category-a.component';
import { CategoryAByCityComponent } from './components/category-a-by-city/category-a-by-city.component';
import { MotorcycleComponent } from 'src/app/categories/category-a/components/motorcycle/motorcycle.component';
import { InstructorComponent } from 'src/app/categories/category-a/components/instructor/instructor.component';
import {route} from 'src/app/categories/category-a/route';
import {CategoriesModule} from 'src/app/categories/categories.module';
import {SharedModule} from 'src/app/shared/shared.module';
import { MotorcycleDetailComponent } from './components/motorcycle-detail/motorcycle-detail.component';

@NgModule({
  declarations: [
    CategoryAComponent,
    CategoryAByCityComponent,
    MotorcycleComponent,
    InstructorComponent,
    MotorcycleDetailComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    FontAwesomeModule,
    SharedModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryAComponent
  ]
})
export class CategoryAModule { }

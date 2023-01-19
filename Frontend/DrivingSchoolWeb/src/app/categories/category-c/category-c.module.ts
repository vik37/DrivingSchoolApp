import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {CategoryCComponent} from 'src/app/categories/category-c/components/category-c/category-c.component';
import {CategoryCByCityComponent} from 'src/app/categories/category-c/components/category-c-by-city/category-c-by-city.component';
import {InstructorComponent} from 'src/app/categories/category-c/components/instructor/instructor.component';
import {route} from 'src/app/categories/category-c/route';
import {CategoriesModule} from 'src/app/categories/categories.module';
import {SharedModule} from 'src/app/shared/shared.module';
import { TruckComponent } from './components/truck/truck.component';
import { InstructorDetailComponent } from './components/instructor-detail/instructor-detail.component';
import { WorkExperienceComponent } from './components/work-experience/work-experience.component';
import { TruckDetailComponent } from './components/truck-detail/truck-detail.component';

@NgModule({
  declarations: [
    CategoryCComponent,
    CategoryCByCityComponent,
    InstructorComponent,
    TruckComponent,
    InstructorDetailComponent,
    WorkExperienceComponent,
    TruckDetailComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    SharedModule,
    FontAwesomeModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryCComponent
  ]
})
export class CategoryCModule { }

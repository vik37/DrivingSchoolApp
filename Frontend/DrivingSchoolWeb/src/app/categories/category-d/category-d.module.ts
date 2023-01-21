import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {route} from 'src/app/categories/category-d/route';
import {CategoriesModule} from 'src/app/categories/categories.module';
import {SharedModule} from 'src/app/shared/shared.module';
import {CategoryDComponent} from 'src/app/categories/category-d/components/category-d/category-d.component';
import {CategoryDByCityComponent} from 'src/app/categories/category-d/components/category-d-by-city/category-d-by-city.component';
import {InstructorComponent} from 'src/app/categories/category-d/components/instructor/instructor.component';
import {InstructorDetailComponent} from 'src/app/categories/category-d/components/instructor-detail/instructor-detail.component';
import {WorkExperienceComponent} from 'src/app/categories/category-d/components/work-experience/work-experience.component';

@NgModule({
  declarations: [
    CategoryDComponent,
    CategoryDByCityComponent,
    InstructorComponent,
    InstructorDetailComponent,
    WorkExperienceComponent
  ],
  imports: [
    CommonModule,
    CategoriesModule,
    FontAwesomeModule,
    SharedModule,
    RouterModule.forChild(route)
  ],
  exports:[
    CategoryDComponent
  ]
})
export class CategoryDModule { }

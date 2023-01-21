import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CategoryCardComponent } from 'src/app/categories/shared/components/category-card/category-card.component';
import { LessonComponent } from './shared/components/lesson/lesson.component';
import { CategoryPerCityComponent } from './shared/components/category-per-city/category-per-city.component';
import { CategoryTypeHeadingComponent } from './shared/components/category-type-heading/category-type-heading.component';
import {SharedModule} from 'src/app/shared/shared.module';


@NgModule({
  declarations: [
    CategoryCardComponent,
    LessonComponent,
    CategoryPerCityComponent,
    CategoryTypeHeadingComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    SharedModule
  ],
  exports:[
    CategoryCardComponent,
    CategoryPerCityComponent,
    LessonComponent,
    CategoryTypeHeadingComponent
  ]
})
export class CategoriesModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CategoryCardComponent } from 'src/app/categories/shared/components/category-card/category-card.component';
import { LessonComponent } from './shared/components/lesson/lesson.component';
import { CategoryPerCityComponent } from './shared/components/category-per-city/category-per-city.component';

@NgModule({
  declarations: [
    CategoryCardComponent,
    LessonComponent,
    CategoryPerCityComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule
  ],
  exports:[
    CategoryCardComponent,
    CategoryPerCityComponent,
    LessonComponent
  ]
})
export class CategoriesModule { }

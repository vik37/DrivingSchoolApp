import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CategoryCardComponent } from 'src/app/categories/shared/components/category-card/category-card.component';

@NgModule({
  declarations: [
    CategoryCardComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule
  ],
  exports:[
    CategoryCardComponent
  ]
})
export class CategoriesModule { }

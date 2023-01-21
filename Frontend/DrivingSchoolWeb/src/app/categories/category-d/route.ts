import { Routes } from "@angular/router";
import {CategoryDComponent} from 'src/app/categories/category-d/components/category-d/category-d.component';
import {CategoryDByCityComponent} from 'src/app/categories/category-d/components/category-d-by-city/category-d-by-city.component';
import {InstructorDetailComponent} from 'src/app/categories/category-d/components/instructor-detail/instructor-detail.component';

export const route: Routes = [
  {path:'', component:CategoryDComponent},
  {path:':id',component:CategoryDByCityComponent},
  {path: ':id/instructor/:instructorId', component: InstructorDetailComponent}
];

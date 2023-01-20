import { Routes } from "@angular/router";
import {CategoryCComponent} from 'src/app/categories/category-c/components/category-c/category-c.component';
import {CategoryCByCityComponent} from 'src/app/categories/category-c/components/category-c-by-city/category-c-by-city.component';
import {InstructorDetailComponent} from 'src/app/categories/category-c/components/instructor-detail/instructor-detail.component';

export const route: Routes = [
  {path:'', component:CategoryCComponent},
  {path:':id',component:CategoryCByCityComponent},
  {path: ':id/instructor/:instructorId', component: InstructorDetailComponent}
]

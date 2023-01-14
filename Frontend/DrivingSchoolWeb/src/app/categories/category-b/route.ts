import { Routes } from "@angular/router";

import {CategoryBComponent} from 'src/app/categories/category-b/components/category-b/category-b.component';
import {CategoryBByCityComponent} from 'src/app/categories/category-b/components/category-b-by-city/category-b-by-city.component';
import {InstructorDetailComponent} from 'src/app/categories/category-b/components/instructor-detail/instructor-detail.component';
export const route: Routes = [
  {path:'',component:CategoryBComponent},
  {path:':id',component:CategoryBByCityComponent},
  {path: ':id/instructor/:instructorId', component: InstructorDetailComponent}
]

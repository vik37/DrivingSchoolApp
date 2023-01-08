import { Routes } from "@angular/router";

import {CategoryBComponent} from 'src/app/categories/category-b/components/category-b/category-b.component';
import {CategoryBByCityComponent} from 'src/app/categories/category-b/components/category-b-by-city/category-b-by-city.component';
import {InstructorComponent} from 'src/app/categories/category-b/components/instructor/instructor.component';
export const route: Routes = [
  {path:'',component:CategoryBComponent},
  {path:':id',component:CategoryBByCityComponent},
  {path: 'instructor', component: InstructorComponent}
]

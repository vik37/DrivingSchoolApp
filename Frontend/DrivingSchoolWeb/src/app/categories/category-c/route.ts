import { Routes } from "@angular/router";

import {CategoryCComponent} from 'src/app/categories/category-c/components/category-c/category-c.component';
import {CategoryCByCityComponent} from 'src/app/categories/category-c/components/category-c-by-city/category-c-by-city.component';
import {InstructorComponent} from 'src/app/categories/category-c/components/instructor/instructor.component';

export const route: Routes = [
  {path:'', component:CategoryCComponent},
  {path:':id',component:CategoryCByCityComponent},
  {path:'instructor',component:InstructorComponent}
]

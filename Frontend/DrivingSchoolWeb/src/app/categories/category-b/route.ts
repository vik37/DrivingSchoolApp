import { Routes } from "@angular/router";

import {CategoryBComponent} from 'src/app/categories/category-b/components/category-b/category-b.component';
import {CategoryBByCityComponent} from 'src/app/categories/category-b/components/category-b-by-city/category-b-by-city.component';

export const route: Routes = [
  {path:'',component:CategoryBComponent},
  {path:':id',component:CategoryBByCityComponent}
]

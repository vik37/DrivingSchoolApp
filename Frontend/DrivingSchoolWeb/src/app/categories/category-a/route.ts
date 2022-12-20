import { Routes } from "@angular/router";

import {CategoryAComponent} from 'src/app/categories/category-a/components/category-a/category-a.component';
import {CategoryABycityComponent} from 'src/app/categories/category-a/components/category-a-bycity/category-a-bycity.component';

export const route: Routes= [
  {path:'', component:CategoryAComponent},
  {path: ':id',component:CategoryABycityComponent}
]

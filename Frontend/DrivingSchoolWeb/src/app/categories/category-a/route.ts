import { Routes } from "@angular/router";
import {CategoryAComponent} from 'src/app/categories/category-a/components/category-a/category-a.component';
import {CategoryAByCityComponent} from 'src/app/categories/category-a/components/category-a-by-city/category-a-by-city.component';
import { AutoLoginPartialRoutesGuard } from "angular-auth-oidc-client";

export const route: Routes= [
  {path:'', component:CategoryAComponent},
  {path: ':id',component:CategoryAByCityComponent,canActivate:[AutoLoginPartialRoutesGuard]}
]

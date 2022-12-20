import { Routes } from "@angular/router";
import { HomeComponent } from "src/app/container/components/home/home.component";
import {AboutComponent} from 'src/app/container/components/about/about.component';
import {ContactComponent} from 'src/app/container/components/contact/contact.component';
import {NotAllowedComponent} from 'src/app/shared/components/not-allowed/not-allowed.component';
import {NotFoundComponent} from  'src/app/shared/components/not-found/not-found.component';
 export const routes: Routes = [
    {path: '', component:HomeComponent},
    {path: 'about', component:AboutComponent},
    {path: 'contact',component:ContactComponent},
    {path: 'category-A',loadChildren: () => import('src/app/categories/category-a/category-a.module').then(c => c.CategoryAModule)},
    {path: 'not-found',component:NotFoundComponent},
    {path: '', redirectTo:'/',pathMatch:'full'},
    {path: '**',component:NotAllowedComponent}
 ]

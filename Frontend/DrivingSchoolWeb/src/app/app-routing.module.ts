import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {routes} from 'src/app/route';

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

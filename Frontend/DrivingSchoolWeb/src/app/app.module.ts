import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from 'src/app/app-routing.module';
import { AppComponent } from 'src/app/app.component';
import {mainComponents} from 'src/app/main-components';
import {modules} from 'src/app/shared-modules';

@NgModule({
  declarations: [
    AppComponent,
    mainComponents
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    HttpClientModule,
    modules
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

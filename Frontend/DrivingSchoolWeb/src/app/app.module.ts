import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './container/components/main/main.component';
import { HeaderComponent } from './container/components/header/header.component';
import { NavbarComponent } from './container/components/navbar/navbar.component';
import { FooterComponent } from './container/components/footer/footer.component';
import { AboutComponent } from './container/components/about/about.component';
import { ContactComponent } from './container/components/contact/contact.component';
import { HomeComponent } from './container/components/home/home.component';
import { NotAllowedComponent } from './container/components/not-allowed/not-allowed.component';
import { NotFoundComponent } from './container/components/not-found/not-found.component';
import {Modules} from 'src/app/shared-modules';
@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    AboutComponent,
    ContactComponent,
    HomeComponent,
    NotAllowedComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    HttpClientModule,
    Modules
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

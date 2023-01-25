import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  template: `
    <header class="header-body">
      <app-navbar></app-navbar>
      <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-9">
          <div class="header-logo">
            <img src="../../../../assets/images/logos/car-icon.png" alt="logo"/>
          </div>
        </div>
        <div class="col-xs-12 col-sm-5 col-md-3">
          <h4>Driving School Grandma</h4>
        </div>
      </div>
    </header>
  `,
  styleUrls: ['./header.component.css']
})
export class HeaderComponent{

  constructor() { }

}

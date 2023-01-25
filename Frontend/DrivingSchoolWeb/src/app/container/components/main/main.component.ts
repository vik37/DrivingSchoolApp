import { Component } from '@angular/core';

@Component({
  selector: 'app-main',
  template: `
    <app-header></app-header>
    <app-loading></app-loading>
    <router-outlet></router-outlet>
    <app-footer></app-footer>
  `,
  styleUrls: ['./main.component.css']
})
export class MainComponent {

  constructor() { }

}

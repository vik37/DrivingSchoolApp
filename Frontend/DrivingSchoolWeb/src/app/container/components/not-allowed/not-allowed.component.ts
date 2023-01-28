import { Component } from '@angular/core';

@Component({
  selector: 'app-not-allowed',
  template: `
      <app-not-found
        [errorMessage]="errorMessage"
      ></app-not-found>
  `,
  styleUrls: ['./not-allowed.component.css']
})
export class NotAllowedComponent {

  public errorMessage: string = 'This page is not allowed';

  constructor() { }

}

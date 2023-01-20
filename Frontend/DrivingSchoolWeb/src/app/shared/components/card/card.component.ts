import { Component } from '@angular/core';

@Component({
  selector: 'app-card',
  template: `
    <div class="card">
      <ng-content select=".card-img-top"></ng-content>
      <div class="card-body">
        <ng-content select=".card-title"></ng-content>
        <ng-content select=".card-text"></ng-content>
        <ng-content select=".color-box"></ng-content>
      </div>
      <ng-content select=".list-group"></ng-content>
      <div class="card-body">
        <ng-content select=".btn"></ng-content>
      </div>
    </div>
  `,
  styleUrls: ['./card.component.css']
})
export class CardComponent {
  constructor() { }
}

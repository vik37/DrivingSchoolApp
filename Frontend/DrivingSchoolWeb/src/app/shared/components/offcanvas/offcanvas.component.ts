import { Component } from '@angular/core';

@Component({
  selector: 'app-offcanvas',
  template:`
      <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasRight" aria-labelledby="offcanvasRightLabel">
        <div class="offcanvas-header">
          <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
        </div>
        <div class="offcanvas-body">
          <ng-content select=".offcanvas-image"></ng-content>
          <ng-content select=".offcanvas-title"></ng-content>
          <ng-content select=".offcanvas-subtitle"></ng-content>
          <hr />
          <ng-content select=".offcanvas-list-description"></ng-content>
        </div>
      </div>
  `,
  styleUrls: ['./offcanvas.component.css']
})
export class OffcanvasComponent {
  constructor() { }
}

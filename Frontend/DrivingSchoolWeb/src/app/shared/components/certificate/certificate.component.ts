import { Component } from '@angular/core';

@Component({
  selector: 'app-certificate',
  template: `
      <div class="certificate">
        <ng-content select="span"></ng-content>
      </div>
  `,
  styleUrls: ['./certificate.component.css']
})
export class CertificateComponent {
  constructor() { }
}

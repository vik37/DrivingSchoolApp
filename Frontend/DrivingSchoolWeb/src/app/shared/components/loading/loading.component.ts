import { Component } from '@angular/core';
import {LoadingService} from 'src/app/shared/services/loading.service';

@Component({
  selector: 'app-loading',
  template: `
    	<div *ngIf="loadingService.loading$ | async" class="position-fixed spinner-circle">
        <div class="spinner-border text-info" role="status">
          <span class="visually-hidden">Loading...</span>
        </div>
        <p class="loading-text">Loading...</p>
      </div>
  `,
  styleUrls: ['./loading.component.css']
})
export class LoadingComponent{

  constructor(public loadingService: LoadingService) { }

}

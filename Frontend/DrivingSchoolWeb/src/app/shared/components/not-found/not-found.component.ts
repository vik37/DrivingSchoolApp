import { Component,Input } from '@angular/core';
import{faHouseMedicalCircleXmark} from '@fortawesome/free-solid-svg-icons';
import{faTriangleExclamation} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-not-found',
  template: `
      <div class="d-flex align-items-center flex-column error-block">
        <div class="error-heading-block">
          <h5>I'm sorry but, {{errorMessage | titlecase}}</h5>
        </div>
        <div class="exclamation-block">
          <fa-icon class="exclamation" [icon]="faTriangleExclamation"></fa-icon>
        </div>
        <div>
          <a type="button" class="btn btn-outline-dark btn-go-home" [href]="['/']" >
            <span>
              Go Home <fa-icon class="hose-media" [icon]="faHouseMedicalCircleXmark"></fa-icon>
            </span>
          </a>
        </div>
      </div>
  `,
  styleUrls: ['./not-found.component.css']
})
export class NotFoundComponent {

  private _errorMessage!:string;
  faTriangleExclamation = faTriangleExclamation;
  faHouseMedicalCircleXmark = faHouseMedicalCircleXmark;
  constructor() { }

  @Input()
  get errorMessage(): string{
    return this._errorMessage;
  }
  set errorMessage(value: string){
    this._errorMessage = value;
  }
}

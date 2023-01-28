import { Component,Input } from '@angular/core';
import{faHouseMedicalCircleXmark} from '@fortawesome/free-solid-svg-icons';
import{faTriangleExclamation} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-not-found',
  templateUrl: './not-found.component.html',
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

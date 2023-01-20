import { Component, Input } from '@angular/core';
import {WorkExperience} from 'src/app/categories/category-c/models/work-experience';
import {TypeOfWorkExperience} from 'src/app/categories/category-c/models/enums/work-experience-type';

@Component({
  selector: 'app-work-experience',
  templateUrl: './work-experience.component.html',
  styleUrls: ['./work-experience.component.css']
})
export class WorkExperienceComponent {
  public typeOfWorkExperience = TypeOfWorkExperience;
  private _workExperience!: WorkExperience;
  constructor() { }
  @Input()
  set workExperience(value:WorkExperience){
    if(value){
      this._workExperience = value;
      console.log(value)
    }
  }
  get workExperience(): WorkExperience{
    return this._workExperience;
  }
}

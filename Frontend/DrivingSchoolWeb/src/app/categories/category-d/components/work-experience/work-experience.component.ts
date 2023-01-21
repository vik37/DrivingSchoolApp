import { Component, Input } from '@angular/core';
import {WorkExperience} from 'src/app/categories/category-d/models/work-experience.interface';
import {TypeOfWorkExperience} from 'src/app/categories/category-d/models/enums/work-experience-type.enum';

@Component({
  selector: 'app-work-experience',
  templateUrl: './work-experience.component.html',
  styleUrls: ['../../../shared/style/work-experience-style.css',
              './work-experience.component.css']
})
export class WorkExperienceComponent{

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

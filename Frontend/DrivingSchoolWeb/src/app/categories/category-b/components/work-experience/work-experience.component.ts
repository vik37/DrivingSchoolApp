import { Component, Input } from '@angular/core';
import {WorkExperience} from 'src/app/categories/category-b/models/work-experience.interface';

@Component({
  selector: 'app-work-experience',
  templateUrl: './work-experience.component.html',
  styleUrls: ['../../../shared/style/work-experience-style.css',
                './work-experience.component.css']
})
export class WorkExperienceComponent {

  private _workExperience!: WorkExperience;

  constructor() { }

  @Input()
  set workExperience(value:WorkExperience){
    if(value){
      this._workExperience = value;
    }
  }
  get workExperience(): WorkExperience{
    return this._workExperience;
  }

}

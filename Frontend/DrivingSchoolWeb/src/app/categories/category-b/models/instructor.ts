import {Base} from 'src/app/categories/shared/models/base';
import {WorkExperience} from 'src/app/categories/category-b/models/work-experience';

export interface Instructor extends Base{
  fullname: string,
  age: number,
  licenceId: string,
  photo: string | null,
  startedDay:string,
  totalWorkExperience:number,
  driveExperience:number,
  instructorAcademy:number,
  isBooked:boolean,
  categoryId:number,
  workExperiencePerCompany:WorkExperience[]
}

import {Base} from 'src/app/categories/shared/models/base';
import {WorkExperience} from 'src/app/categories/category-d/models/work-experience';
import {InstructorCategoryLicence} from 'src/app/categories/category-d/models/instructor-category-licence';

export interface Instructor extends Base{
  fullname: string,
  age: number,
  licenceId: string,
  photo: string | null,
  startedDay:string,
  totalWorkExperience:number,
  totalDriveExperience:number,
  busDriveExperience:number,
  instructorAcademy:string,
  isBooked:boolean,
  categoryId:number,
  workExperiences:WorkExperience[],
  categoryLicences:InstructorCategoryLicence[]
}

import {Base} from 'src/app/categories/shared/models/base.interface';
import {WorkExperience} from 'src/app/categories/category-d/models/work-experience.interface';
import {InstructorCategoryLicence} from 'src/app/categories/category-d/models/instructor-category-licence.interface';

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
  workExperiencePerCompany:WorkExperience[],
  categoryLicences:InstructorCategoryLicence[]
}

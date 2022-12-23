import {Base} from 'src/app/categories/shared/models/base';
import {TypeOfWorkExperience} from 'src/app/categories/category-c/models/enums/work-experience-type';

export interface WorkExperience extends Base{
  experience:number,
  company:string,
  categoryType:TypeOfWorkExperience
}

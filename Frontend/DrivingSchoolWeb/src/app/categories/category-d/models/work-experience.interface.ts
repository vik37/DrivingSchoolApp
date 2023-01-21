import {Base} from 'src/app/categories/shared/models/base.interface';
import {TypeOfWorkExperience} from 'src/app/categories/category-d/models/enums/work-experience-type.enum';

export interface WorkExperience extends Base{
  experience:number,
  company:string,
  typeOfWorkExperience:TypeOfWorkExperience
}

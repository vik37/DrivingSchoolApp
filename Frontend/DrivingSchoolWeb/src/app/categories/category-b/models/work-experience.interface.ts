import {Base} from 'src/app/categories/shared/models/base.interface';

export interface WorkExperience extends Base{
  experience:number,
  company:string,
  instructorId:number
}

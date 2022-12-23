import {Base} from 'src/app/categories/shared/models/base';

export interface WorkExperience extends Base{
  experience:number,
  company:string,
  instructorId:number
}

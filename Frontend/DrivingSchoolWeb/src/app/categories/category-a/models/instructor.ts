import {Base} from 'src/app/categories/shared/models/base';

export interface Instructor extends Base{
  fullname: string,
  age: number,
  photo: string | null,
  startedDay:string,
  experience:number,
  isBooked:boolean,
  categoryId:number
}

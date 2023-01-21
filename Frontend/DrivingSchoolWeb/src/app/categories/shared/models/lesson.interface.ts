import {Base} from 'src/app/categories/shared/models/base.interface';

export interface Lesson extends Base{
  price: number,
  testPrice:number,
  description:string,
  licenceDescription: string,
  duration: number,
  virtualPracticePrice: number | null
}

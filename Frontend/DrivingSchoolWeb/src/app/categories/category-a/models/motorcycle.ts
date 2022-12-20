import {Base} from 'src/app/categories/shared/models/base';

export interface Motorcycle extends Base{
  type:string,
  model:string,
  year: number,
  fuel: number,
  capacity:number,
  weight: number,
  speed:number,
  color: string,
  photo:string,
  availableMotorcycles:number
}

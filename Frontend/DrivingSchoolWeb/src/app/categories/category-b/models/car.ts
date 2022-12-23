import {Base} from 'src/app/categories/shared/models/base';

export interface Car extends Base{
  type:string,
  model:string,
  year:number,
  fuel:string,
  fuelConsuption:string,
  power:number,
  length:number,
  speed:number,
  doors:number,
  transmission:string,
  color:string,
  photo:string,
  availableCars:number
}

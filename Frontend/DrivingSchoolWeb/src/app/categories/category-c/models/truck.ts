import {Base} from 'src/app/categories/shared/models/base';

export interface Truck extends Base{
  truckNumber:number,
  type:string,
  model:string,
  year:number,
  fuel:string,
  power:number,
  transmission:string,
  cylinderCapacity:number,
  color:string,
  photo:string,
  availableTruck:number
}

import {Base} from 'src/app/categories/shared/models/base.interface';

export interface  Category extends Base{
  city: string,
  address: string,
  phone: string
}

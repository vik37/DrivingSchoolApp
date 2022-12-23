import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {Lesson} from 'src/app/categories/category-b/models/lesson';
import {Truck} from 'src/app/categories/category-c/models/truck';

export interface CategoryC extends Category{
  instructors:Instructor[],
  lessons:Lesson[],
  trucks:Truck[]
}

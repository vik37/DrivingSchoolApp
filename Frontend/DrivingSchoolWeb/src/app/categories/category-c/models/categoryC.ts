import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-c/models/instructor';
import {CategoryCLesson} from 'src/app/categories/category-c/models/lesson-categoryC';
import {Truck} from 'src/app/categories/category-c/models/truck';

export interface CategoryC extends Category{
  trucks:Truck[],
  lessons:CategoryCLesson[],
  instructors:Instructor[]
}

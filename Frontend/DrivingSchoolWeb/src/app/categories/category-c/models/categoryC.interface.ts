import {Category} from 'src/app/categories/shared/models/category.interface';
import {Instructor} from 'src/app/categories/category-c/models/instructor.interface';
import {CategoryCLesson} from 'src/app/categories/category-c/models/lesson-categoryC.interface';
import {Truck} from 'src/app/categories/category-c/models/truck.interface';

export interface CategoryC extends Category{
  trucks:Truck[],
  lessons:CategoryCLesson[],
  instructors:Instructor[]
}

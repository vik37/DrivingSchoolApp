import {Category} from 'src/app/categories/shared/models/category.interface';
import {Instructor} from 'src/app/categories/category-a/models/instructor.interface';
import {CategoryALesson} from 'src/app/categories/category-a/models/lesson-categoryA.interface';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle.interface';

export interface CategoryA extends Category{
  instructors:Instructor[],
  lessons:CategoryALesson[],
  motorcycles:Motorcycle[]
}

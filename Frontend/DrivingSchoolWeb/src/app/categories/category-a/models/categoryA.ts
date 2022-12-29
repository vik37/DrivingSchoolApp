import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-a/models/instructor';
import {CategoryALesson} from 'src/app/categories/category-a/models/lesson-categoryA';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle';

export interface CategoryA extends Category{
  instructors:Instructor[],
  lessons:CategoryALesson[],
  motorcycles:Motorcycle[]
}

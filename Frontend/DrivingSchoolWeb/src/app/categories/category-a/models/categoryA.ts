import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-a/models/instructor';
import {Lesson} from 'src/app/categories/category-a/models/lesson';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle';

export interface CategoryA extends Category{
  instructors:Instructor[],
  lessons:Lesson[],
  motorcycles:Motorcycle[]
}

import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-d/models/instructor';
import {CategoryDLesson} from 'src/app/categories/category-d/models/lesson-categoryD';

export interface CategoryD extends Category{
  lessons:CategoryDLesson[],
  instructors:Instructor[]
}

import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-d/models/instructor';
import {Lesson} from 'src/app/categories/category-d/models/lesson';

export interface CategoryD extends Category{
  lessons:Lesson[],
  instructors:Instructor[]
}

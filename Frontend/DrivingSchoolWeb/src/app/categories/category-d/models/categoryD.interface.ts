import {Category} from 'src/app/categories/shared/models/category.interface';
import {Instructor} from 'src/app/categories/category-d/models/instructor.interface';
import {CategoryDLesson} from 'src/app/categories/category-d/models/lesson-categoryD.interface';

export interface CategoryD extends Category{
  lessons:CategoryDLesson[],
  instructors:Instructor[]
}

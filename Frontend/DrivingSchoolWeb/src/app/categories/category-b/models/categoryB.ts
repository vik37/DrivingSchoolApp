import {Category} from 'src/app/categories/shared/models/category';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {Lesson} from 'src/app/categories/category-b/models/lesson';
import {Car} from 'src/app/categories/category-b/models/car';

export interface CategoryB extends Category{
  cars:Car[],
  instructors:Instructor[],
  lessons:Lesson[]
}

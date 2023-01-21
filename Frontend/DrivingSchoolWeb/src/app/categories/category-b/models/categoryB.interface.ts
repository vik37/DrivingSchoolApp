import {Category} from 'src/app/categories/shared/models/category.interface';
import {Instructor} from 'src/app/categories/category-b/models/instructor.interface';
import {CategoryBLesson} from 'src/app/categories/category-b/models/lesson-categoryB.interface';
import {Car} from 'src/app/categories/category-b/models/car.interface';

export interface CategoryB extends Category{
  lessons:CategoryBLesson[],
  instructors:Instructor[],
  cars:Car[]
}

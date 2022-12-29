import {Lesson} from 'src/app/categories/shared/models/lesson';
import {LessonType} from 'src/app/categories/category-c/models/enums/lesson-type';

export interface CategoryCLesson extends Lesson{
  type:LessonType,
  discount:number | null
}

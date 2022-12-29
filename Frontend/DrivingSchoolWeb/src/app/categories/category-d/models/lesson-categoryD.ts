import {Lesson} from 'src/app/categories/shared/models/lesson';
import {LessonType} from 'src/app/categories/category-d/models/enums/lesson-type';

export interface CategoryDLesson extends Lesson{
  type:LessonType,
  discount:number | null
}

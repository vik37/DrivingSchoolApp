import {Lesson} from 'src/app/categories/shared/models/lesson';
import {LessonType} from 'src/app/categories/category-b/models/enums/lesson-type';

export interface CategoryBLesson extends Lesson{
  type:LessonType,
  discount:number | null
}

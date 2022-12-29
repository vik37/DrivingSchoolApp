import {Lesson} from 'src/app/categories/shared/models/lesson';
import {LessonType} from 'src/app/categories/category-a/models/enums/lesson-type';

export interface CategoryALesson extends Lesson{
  type:LessonType
}

import {Lesson} from 'src/app/categories/shared/models/lesson.interface';
import {LessonType} from 'src/app/categories/category-a/models/enums/lesson-type.enum';

export interface CategoryALesson extends Lesson{
  type:LessonType
}

import {Lesson} from 'src/app/categories/shared/models/lesson.interface';
import {LessonType} from 'src/app/categories/category-d/models/enums/lesson-type.enum';

export interface CategoryDLesson extends Lesson{
  type:LessonType,
  discount:number | null
}

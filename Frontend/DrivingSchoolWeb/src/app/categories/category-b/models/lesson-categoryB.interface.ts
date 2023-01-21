import {Lesson} from 'src/app/categories/shared/models/lesson.interface';
import {LessonType} from 'src/app/categories/category-b/models/enums/lesson-type.enum';

export interface CategoryBLesson extends Lesson{
  type:LessonType,
  discount:number | null
}

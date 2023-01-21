import {Lesson} from 'src/app/categories/shared/models/lesson.interface';
import {LessonType} from 'src/app/categories/category-c/models/enums/lesson-type.enum';

export interface CategoryCLesson extends Lesson{
  type:LessonType,
  discount:number | null
}

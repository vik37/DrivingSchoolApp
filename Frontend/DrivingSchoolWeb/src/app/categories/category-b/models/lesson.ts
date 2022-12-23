import {Base} from 'src/app/categories/shared/models/base';
import {LessonType} from 'src/app/categories/category-b/models/enums/lesson-type';

export interface Lesson extends Base{
  lessonType:LessonType,
  price: number,
  testPrice:number,
  description:string,
  licenceDescription: string,
  duration: number,
  virtualPracticePrice: number | null,
  discount:number | null
}

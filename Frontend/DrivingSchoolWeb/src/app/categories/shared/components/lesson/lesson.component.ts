import { Component,Input, OnChanges, SimpleChanges } from '@angular/core';
import {Lesson} from 'src/app/categories/shared/models/lesson.interface';
import {faCartShopping} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-lesson',
  templateUrl: './lesson.component.html',
  styleUrls: ['./lesson.component.css']
})
export class LessonComponent implements OnChanges {
  public faCartShopping = faCartShopping;
  @Input()lesson: Lesson | undefined;
  constructor() { }

  ngOnChanges(changes: SimpleChanges): void{}
}

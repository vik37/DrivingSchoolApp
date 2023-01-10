import { Component,Input, OnChanges, SimpleChanges } from '@angular/core';
import {Lesson} from 'src/app/categories/shared/models/lesson';

@Component({
  selector: 'app-lesson',
  templateUrl: './lesson.component.html',
  styleUrls: ['./lesson.component.css']
})
export class LessonComponent implements OnChanges {

  @Input()lesson: Lesson | undefined;
  constructor() { }

  ngOnChanges(changes: SimpleChanges): void{

  }
}

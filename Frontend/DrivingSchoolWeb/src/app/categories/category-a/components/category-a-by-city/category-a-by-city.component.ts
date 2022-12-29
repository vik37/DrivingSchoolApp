import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import {CategoryAService} from 'src/app/categories/category-a/services/category-a.service';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA';
import {CategoryALesson} from 'src/app/categories/category-a/models/lesson-categoryA';
import {LessonType} from 'src/app/categories/category-a/models/enums/lesson-type';
import {PhotoService} from 'src/app/shared/services/photo.service';
import { Observable } from 'rxjs';
import {switchMap, tap,map,filter} from 'rxjs/operators';

@Component({
  selector: 'app-category-a-bycity',
  templateUrl: './category-a-by-city.component.html',
  styleUrls: ['./category-a-by-city.component.css'],
  providers: [PhotoService]
})
export class CategoryAByCityComponent implements OnInit {

  categoryA$: Observable<CategoryA> =  new Observable<CategoryA>();
  lesson$: Observable<CategoryALesson | undefined> = new Observable<CategoryALesson | undefined>();
  nextLessonIndex:LessonType = LessonType.Test;
  lessonType = LessonType;
  photoUrl: string = '';
  disable: boolean = true;

  constructor(private route: ActivatedRoute, private categoryAService: CategoryAService,
              private photoService: PhotoService) { }

  ngOnInit(): void {
      this.categoryA$ =  this.route.paramMap.pipe(
        switchMap((params:ParamMap) =>{
          return this.categoryAService.getById(params.get('id') as string)
      })
    );
    this.loadLesson();
  }
  loadLesson():  void{
    this.lesson$ = this.categoryA$.pipe(
                  tap(data => this.loadPhoto(data.city.toLocaleLowerCase())),
                  map(data => data.lessons),
                  map(x => x.find(s => s.type === this.nextLessonIndex))
                );
    this.lesson$.subscribe(data => console.log('lesson: ', data))
  }
  loadPhoto(city:string): void{
    this.photoUrl = this.photoService.uri+'city/'+city;
    console.log(this.photoUrl);
  }
  getLessonByType(type:LessonType): void{
    console.log('lesson type: ',type);
    this.nextLessonIndex = type;
    this.disable = !this.disable;
    this.loadLesson();
  }
}

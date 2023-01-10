import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import {switchMap, tap,map} from 'rxjs/operators';
import {CategoryAService} from 'src/app/categories/category-a/services/category-a.service';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA';
import {CategoryALesson} from 'src/app/categories/category-a/models/lesson-categoryA';
import {Instructor} from 'src/app/categories/category-a/models/instructor';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle';
import {LessonType} from 'src/app/categories/category-a/models/enums/lesson-type';


@Component({
  selector: 'app-category-a-bycity',
  templateUrl: './category-a-by-city.component.html',
  styleUrls: ['./category-a-by-city.component.css']
})
export class CategoryAByCityComponent implements OnInit {

  public categoryA$: Observable<CategoryA> =  new Observable<CategoryA>();
  public lesson$: Observable<CategoryALesson | undefined>
                    = new Observable<CategoryALesson | undefined>();
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public motorcycles$: Observable<Motorcycle[]> = new Observable<Motorcycle[]>();
  public currentLessonType:LessonType = LessonType.Theory;
  public lessonType = LessonType;
  public disable: boolean = true;
  public motorcycleDetail: Motorcycle | undefined;

  constructor(private route: ActivatedRoute, private categoryAService: CategoryAService)
        { }

  ngOnInit(): void {
    this.categoryA$ =  this.route.paramMap.pipe(
      switchMap((params:ParamMap) =>{
        return this.categoryAService.getById(params.get('id') as string)
      })
    );
    this.loadLesson();
    this.loadInstructors();
    this.loadMotorcycles();
  }
  loadLesson():  void{
    this.lesson$ = this.categoryA$.pipe(
                  map(data => data.lessons),
                  map(x => x.find(s => s.type === this.currentLessonType))
                );
  }
  selectLessonByType(type:LessonType): void{
    this.currentLessonType = type;
    this.disable = !this.disable;
    this.loadLesson();
  }
  loadInstructors(): void{
    this.instructors$ = this.categoryA$.pipe(
      map(data => data.instructors)
    );
  }
  loadMotorcycles(): void{
    this.motorcycles$ = this.categoryA$.pipe(
      map(data => data.motorcycles),
      tap(data => this.motorcycleDetail = data.find(x => x.id === 1)??undefined)
    );
  }
  getMotorDetail(motor: Motorcycle): void{
    this.motorcycleDetail = motor;
  }
}

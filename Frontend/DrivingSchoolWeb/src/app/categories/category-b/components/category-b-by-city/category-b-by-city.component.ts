import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import {switchMap, tap,map} from 'rxjs/operators';
import {CategoryBService} from 'src/app/categories/category-b/services/category-b.service';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB';
import {CategoryBLesson} from 'src/app/categories/category-b/models/lesson-categoryB';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {Car} from 'src/app/categories/category-b/models/car';
import {LessonType} from 'src/app/categories/category-b/models/enums/lesson-type';

@Component({
  selector: 'app-category-b-by-city',
  templateUrl: './category-b-by-city.component.html',
  styleUrls: ['./category-b-by-city.component.css']
})
export class CategoryBByCityComponent implements OnInit {

  public categoryB$: Observable<CategoryB> = this.route.paramMap.pipe(
                        switchMap((params:ParamMap) =>{
                          return this.categoryBService.getById(params.get('id') as string)
                          })
                        );
  public lesson$: Observable<CategoryBLesson | undefined>
                    = new Observable<CategoryBLesson | undefined>();
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public cars$: Observable<Car[]> = new Observable<Car[]>();
  public currentLessonType:LessonType = LessonType.Theory;
  public lessonType = LessonType;
  public carDetail: Car | undefined;
  public currentLessonIndex: number = 0;
  public activeClass:string = "lesson-type-selector-active";

  constructor(private route: ActivatedRoute, private categoryBService: CategoryBService)
        { }

  ngOnInit(): void {
    this.loadLesson();
    this.loadInstructors();
    this.loadCars();
  }

  loadLesson():  void{
    this.lesson$ = this.categoryB$.pipe(
                  map(data => data.lessons),
                  map(x => x.find(s => s.type === this.currentLessonType))
                );
  }
  loadInstructors(): void{
    this.instructors$ = this.categoryB$.pipe(
      map(data => data.instructors)
    );
  }
  selectLessonByType(type:number,index:number): void{
    this.currentLessonType = type as LessonType;
    this.currentLessonIndex = index;
    this.loadLesson();
  }
  loadCars(): void{
    this.cars$ = this.categoryB$.pipe(
      map(data => data.cars),
      tap(data => this.carDetail = data.find(x => x.id === 1)??undefined)
    );
  }
  getCarDetail(car: Car): void{
    if(car){
      this.carDetail = car;
    }
  }
}

import { Component,OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable,Subscription } from 'rxjs';
import { switchMap, tap,map,take } from 'rxjs/operators';
import {CategoryBService} from 'src/app/categories/category-b/services/category-b.service';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB.interface';
import {CategoryBLesson} from 'src/app/categories/category-b/models/lesson-categoryB.interface';
import {Instructor} from 'src/app/categories/category-b/models/instructor.interface';
import {Car} from 'src/app/categories/category-b/models/car.interface';
import {LessonType} from 'src/app/categories/category-b/models/enums/lesson-type.enum';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';

@Component({
  selector: 'app-category-b-by-city',
  templateUrl: './category-b-by-city.component.html',
  styleUrls: ['../../../shared/style/category-city-style.css',
              './category-b-by-city.component.css']
})
export class CategoryBByCityComponent implements OnInit, OnDestroy {

  public categoryTypeHeading: CategoryType = CategoryType.B;
  public categoryB$: Observable<CategoryB> = new Observable<CategoryB>();
  public currentLessonType:LessonType = LessonType.Theory;
  public currentLessonIndex: number = 0;
  public lessonType = LessonType;
  public activeClass:string = "lesson-type-selector-active";
  public lesson: CategoryBLesson | undefined;
  private _lessonSubscription = new Subscription();
  private _lessons: CategoryBLesson[] = [];
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public cars$: Observable<Car[]> = new Observable<Car[]>();
  public carDetail: Car | undefined;

  constructor(private route: ActivatedRoute, private categoryBService: CategoryBService,
              private loadingService: LoadingService){ }

  ngOnInit(): void {
    this.loadCategory();
  }
  loadCategory(): void{
    let category = this.route.paramMap.pipe(
                              take(1),
                              switchMap((params:ParamMap) =>{
                                return this.categoryBService.getById(params.get('id') as string)
                                })
                              );
    this.categoryB$ = this.loadingService.showLoaderUntilCompleted(category);
    this.loadLesson();
    this.loadInstructors();
    this.loadCars();
  }
  loadLesson():  void{
    this._lessonSubscription = this.categoryB$.pipe(
                  map(data => data.lessons)
                ).subscribe(data =>{
                  this._lessons = data
                  this.lesson = data[0]
                });
  }
  selectLessonByType(type:number,index:number): void{
    this.lesson = this._lessons[index];
    this.currentLessonType = type as LessonType;
    this.currentLessonIndex = index;
  }
  loadInstructors(): void{
    this.instructors$ = this.categoryB$.pipe(
      map(data => data.instructors)
    );
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
  ngOnDestroy(): void {
    this._lessonSubscription.unsubscribe();
  }

}

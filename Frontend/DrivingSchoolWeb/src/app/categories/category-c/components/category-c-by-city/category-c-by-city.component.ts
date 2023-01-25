import { Component,OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { switchMap,tap,map,take } from 'rxjs/operators';
import {CategoryCService} from 'src/app/categories/category-c/services/category-c.service';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC.interface';
import {CategoryCLesson} from 'src/app/categories/category-c/models/lesson-categoryC.interface';
import {Instructor} from 'src/app/categories/category-c/models/instructor.interface';
import {Truck} from 'src/app/categories/category-c/models/truck.interface';
import {LessonType} from 'src/app/categories/category-c/models/enums/lesson-type.enum';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';

@Component({
  selector: 'app-category-c-by-city',
  templateUrl: './category-c-by-city.component.html',
  styleUrls: ['../../../shared/style/category-city-style.css',
              './category-c-by-city.component.css']
})
export class CategoryCByCityComponent implements OnInit,OnDestroy {

  public categoryTypeHeading: CategoryType = CategoryType.C;
  public categoryC$: Observable<CategoryC> = new Observable<CategoryC>();
  public currentLessonType:LessonType = LessonType.Theory;
  public lessonType = LessonType;
  public currentLessonIndex: number = 0;
  public activeClass:string = "lesson-type-selector-active";
  public lesson: CategoryCLesson | undefined;
  private lessonSubscription = new Subscription();
  private lessons: CategoryCLesson[] = [];
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public trucks$: Observable<Truck[]> = new Observable<Truck[]>();
  public truckDetail: Truck | undefined;

  constructor(private route: ActivatedRoute, private categoryCService:CategoryCService,
              private loadingService: LoadingService) { }

  ngOnInit(): void {
    this.loadCategory();
  }
  loadCategory(): void{
    let category = this.route.paramMap.pipe(
                              take(1),
                              switchMap((params:ParamMap) =>{
                                return this.categoryCService.getById(params.get('id') as string)
                                })
                              );
    this.categoryC$ = this.loadingService.showLoaderUntilCompleted(category);
    this.loadLesson();
    this.loadInstructors();
    this.loadTrucks();
  }
  loadLesson():  void{
    this.lessonSubscription = this.categoryC$.pipe(
                  map(data => data.lessons)
                ).subscribe(data =>{
                  this.lessons = data
                  this.lesson = data[0]
                });
  }
  selectLessonByType(type:number,index:number): void{
    this.lesson = this.lessons[index];
    this.currentLessonType = type as LessonType;
    this.currentLessonIndex = index;
  }
  loadInstructors(): void{
    this.instructors$ = this.categoryC$.pipe(
      map(data => data.instructors)
    );
  }
  loadTrucks(): void{
    this.trucks$ = this.categoryC$.pipe(
      map(data => data.trucks),
      tap(data => this.truckDetail = data.find(x => x.id === 1)??undefined)
    );
  }
  getTruckDetail(truck: Truck): void{
    if(truck){
      this.truckDetail = truck;
    }
  }
  ngOnDestroy(): void {
    this.lessonSubscription.unsubscribe();
  }
}

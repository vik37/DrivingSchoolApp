import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable, Subscription, Subject } from 'rxjs';
import {switchMap, tap,map,take, filter} from 'rxjs/operators';
import {CategoryAService} from 'src/app/categories/category-a/services/category-a.service';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA.interface';
import {CategoryALesson} from 'src/app/categories/category-a/models/lesson-categoryA.interface';
import {Instructor} from 'src/app/categories/category-a/models/instructor.interface';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle.interface';
import {LessonType} from 'src/app/categories/category-a/models/enums/lesson-type.enum';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';

@Component({
  selector: 'app-category-a-bycity',
  templateUrl: './category-a-by-city.component.html',
  styleUrls: ['../../../shared/style/category-city-style.css',
              './category-a-by-city.component.css']
})
export class CategoryAByCityComponent implements OnInit,OnDestroy {

  public categoryTypeHeading: CategoryType = CategoryType.A;
  public categoryA$: Observable<CategoryA> =  new Observable<CategoryA>();
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public motorcycles$: Observable<Motorcycle[]> = new Observable<Motorcycle[]>();
  public lessonType = LessonType;
  public disable: boolean = true;
  public motorcycleDetail: Motorcycle | undefined;
  private lessonSubscription = new Subscription();
  private lessons: CategoryALesson[] = [];
  public lesson: CategoryALesson | undefined;

  constructor(private route: ActivatedRoute, private categoryAService: CategoryAService,
              private loadingService: LoadingService)
        { }

  ngOnInit(): void {
    this.loadCategory();
  }
  loadCategory(): void{
    let categoryA = this.route.paramMap.pipe(
                    take(1),
                    switchMap((params:ParamMap) =>{
                      return this.categoryAService.getById(params.get('id') as string)
                    })
                  );
    this.categoryA$ = this.loadingService.showLoaderUntilCompleted(categoryA);
    this.loadLesson();
    this.loadInstructors();
    this.loadMotorcycles();
  }
  loadLesson():  void{
    this.lessonSubscription = this.categoryA$.pipe(
      map(data => data.lessons)).subscribe(data =>{
            this.lessons = data
            this.lesson = data[0];
      }
    )
  }
  selectLessonByType(type:LessonType): void{
    this.lesson = this.lessons.find(x => x.type === type)??undefined;
    this.disable = !this.disable;
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

  ngOnDestroy(): void {
    this.lessonSubscription.unsubscribe();
  }
}

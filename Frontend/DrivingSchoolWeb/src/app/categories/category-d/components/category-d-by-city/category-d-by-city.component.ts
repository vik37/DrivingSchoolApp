import { Component,OnInit,OnDestroy } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable,Subscription,EMPTY } from 'rxjs';
import { switchMap,map,take,catchError } from 'rxjs/operators';
import {CategoryDService} from 'src/app/categories/category-d/services/category-d.service';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD.interface';
import {CategoryDLesson} from 'src/app/categories/category-d/models/lesson-categoryD.interface';
import {Instructor} from 'src/app/categories/category-d/models/instructor.interface';
import {LessonType} from 'src/app/categories/category-d/models/enums/lesson-type.enum';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Component({
  selector: 'app-category-d-by-city',
  templateUrl: './category-d-by-city.component.html',
  styleUrls: ['../../../shared/style/category-city-style.css',
              './category-d-by-city.component.css'],
  providers: [PhotoService]
})
export class CategoryDByCityComponent implements OnInit,OnDestroy {

  public categoryTypeHeading: CategoryType = CategoryType.D;
  public categoryD$: Observable<CategoryD> = new Observable<CategoryD>();
  public currentLessonType:LessonType = LessonType.Theory;
  public currentLessonIndex: number = 0;
  public activeClass:string = "lesson-type-selector-active";
  public lessonType = LessonType;
  public lesson: CategoryDLesson | undefined;
  private _lessonSubscription = new Subscription();
  private _lessons: CategoryDLesson[] = [];
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public photoUrl:string = this.photoService.uri;
  public responseError: ResponseError | undefined;

  constructor(private route: ActivatedRoute, private categoryDService:CategoryDService,
              private photoService: PhotoService, private loadingService: LoadingService) { }

  ngOnInit(): void {
    this.loadCategory();
  }
  loadCategory(): void{
    let category = this.route.paramMap.pipe(
                              take(1),
                              switchMap((params:ParamMap) =>{
                                return this.categoryDService.getById(params.get('id') as string)
                                }),
                                catchError((err: ResponseError)=>{
                                  this.responseError = err;
                                  return EMPTY
                                })
                              );
    this.categoryD$ = this.loadingService.showLoaderUntilCompleted(category);
    this.loadLesson();
    this.loadInstructors();
  }
  loadLesson():  void{
    this._lessonSubscription = this.categoryD$.pipe(
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
    this.instructors$ = this.categoryD$.pipe(
      map(data => data.instructors)
    )
  }
  ngOnDestroy(): void {
    this._lessonSubscription.unsubscribe();
  }
}

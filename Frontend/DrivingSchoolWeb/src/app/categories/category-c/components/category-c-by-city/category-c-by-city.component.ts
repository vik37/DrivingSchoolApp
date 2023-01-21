import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import {switchMap, tap,map} from 'rxjs/operators';
import {CategoryCService} from 'src/app/categories/category-c/services/category-c.service';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC.interface';
import {CategoryCLesson} from 'src/app/categories/category-c/models/lesson-categoryC.interface';
import {Instructor} from 'src/app/categories/category-c/models/instructor.interface';
import {Truck} from 'src/app/categories/category-c/models/truck.interface';
import {LessonType} from 'src/app/categories/category-c/models/enums/lesson-type.enum';
import { PhotoService } from 'src/app/shared/services/photo.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

@Component({
  selector: 'app-category-c-by-city',
  templateUrl: './category-c-by-city.component.html',
  styleUrls: ['../../../shared/style/category-city-style.css',
              './category-c-by-city.component.css'],
  providers: [PhotoService]
})
export class CategoryCByCityComponent implements OnInit {

  public categoryTypeHeading: CategoryType = CategoryType.C;
  public categoryC$: Observable<CategoryC> = this.route.paramMap.pipe(
    switchMap((params:ParamMap) =>{
      return this.categoryCService.getById(params.get('id') as string)
      })
    );
public lesson$: Observable<CategoryCLesson | undefined>
= new Observable<CategoryCLesson | undefined>();
public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
public trucks$: Observable<Truck[]> = new Observable<Truck[]>();
public currentLessonType:LessonType = LessonType.Theory;
public lessonType = LessonType;
public truckDetail: Truck | undefined;
public currentLessonIndex: number = 0;
public activeClass:string = "lesson-type-selector-active";

  constructor(private route: ActivatedRoute, private categoryCService:CategoryCService) { }

  ngOnInit(): void {
    this.loadLesson();
    this.loadInstructors();
    this.loadTrucks();
  }

  loadLesson():  void{
    this.lesson$ = this.categoryC$.pipe(
                  map(data => data.lessons),
                  map(x => x.find(s => s.type === this.currentLessonType))
                );
  }
  loadInstructors(): void{
    this.instructors$ = this.categoryC$.pipe(
      map(data => data.instructors)
    )
  }
  selectLessonByType(type:number,index:number): void{
    this.currentLessonType = type as LessonType;
    this.currentLessonIndex = index;
    this.loadLesson();
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
}

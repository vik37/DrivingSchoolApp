import { Component,OnInit } from '@angular/core';
import { ActivatedRoute,ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import { switchMap,map } from 'rxjs/operators';
import {CategoryDService} from 'src/app/categories/category-d/services/category-d.service';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD.interface';
import {CategoryDLesson} from 'src/app/categories/category-d/models/lesson-categoryD.interface';
import {Instructor} from 'src/app/categories/category-d/models/instructor.interface';
import {LessonType} from 'src/app/categories/category-d/models/enums/lesson-type.enum';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

@Component({
  selector: 'app-category-d-by-city',
  templateUrl: './category-d-by-city.component.html',
  styleUrls: ['../../../shared/style/category-city-style.css',
              './category-d-by-city.component.css'],
  providers: [PhotoService]
})
export class CategoryDByCityComponent implements OnInit {

  public categoryTypeHeading: CategoryType = CategoryType.D;
  public categoryD$: Observable<CategoryD> = this.route.paramMap.pipe(
    switchMap((params:ParamMap) =>{
      return this.categoryDService.getById(params.get('id') as string)
      })
    );
  public lesson$: Observable<CategoryDLesson | undefined>
  = new Observable<CategoryDLesson | undefined>();
  public instructors$: Observable<Instructor[]> = new Observable<Instructor[]>();
  public currentLessonType:LessonType = LessonType.Theory;
  public currentLessonIndex: number = 0;
  public activeClass:string = "lesson-type-selector-active";
  public lessonType = LessonType;

  constructor(private route: ActivatedRoute, private categoryDService:CategoryDService) { }

  ngOnInit(): void {
    this.loadLesson();
    this.loadInstructors();
  }

  loadLesson():  void{
    this.lesson$ = this.categoryD$.pipe(
                  map(data => data.lessons),
                  map(x => x.find(s => s.type === this.currentLessonType))
                );
  }
  loadInstructors(): void{
    this.instructors$ = this.categoryD$.pipe(
      map(data => data.instructors)
    )
  }
  selectLessonByType(type:number,index:number): void{
    this.currentLessonType = type as LessonType;
    this.currentLessonIndex = index;
    this.loadLesson();
  }
}

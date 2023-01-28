import { Component,OnInit } from '@angular/core';
import { Observable,EMPTY } from 'rxjs';
import { tap,map,switchMap,take,catchError } from 'rxjs/operators';
import { ActivatedRoute,ParamMap } from '@angular/router';
import {Instructor} from 'src/app/categories/category-c/models/instructor.interface';
import {WorkExperience} from 'src/app/categories/category-c/models/work-experience.interface';
import {InstructorService} from 'src/app/categories/category-c/services/instructor.service';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {HtmlTextElementService} from 'src/app/shared/services/helper/html-elements-builder/html-element.service';
import {ParentTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/parent-text-tag.enum';
import {ChildTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/child-text-tag.enum';
import {CategoryType}from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Component({
  selector: 'app-instructor-detail',
  templateUrl: './instructor-detail.component.html',
  styleUrls: ['../../../shared/style/instructor-detail-shared-style.css',
              './instructor-detail.component.css'],
  providers: [PhotoService, HtmlTextElementService]
})
export class InstructorDetailComponent implements OnInit {

  public categoryType = CategoryType;
  public instructor$: Observable<Instructor> = new Observable<Instructor>();
  public workExperience$: Observable<WorkExperience[]> = new Observable<WorkExperience[]>();
  public photoUrl$: Observable<string> = new Observable<string>();
  public description:string = '';
  public workExperienceLength:number = 0;
  public responseError: ResponseError | undefined;

  constructor(private route: ActivatedRoute, private instructorService: InstructorService,
            private photoService:PhotoService,
            private htmlTextElementService: HtmlTextElementService,
            private loaderService: LoadingService) { }

  ngOnInit(): void {
    this.loadInstructor();
    this.loadPhoto();
    this.loadWorkExperience();
  }
  loadInstructor(): void{
    let instructor = this.route.paramMap.pipe(
                    take(1),
                    switchMap((params:ParamMap)=>{
                      const categoryBId = params.get('id' as string);
                      const instructorId = params.get('instructorId' as string);
                      return this.instructorService.getInstructorById(categoryBId??'',instructorId??'')
                    }),
                    catchError((err: ResponseError)=>{
                      this.responseError = err;
                      return EMPTY
                    }));
    this.instructor$ = this.loaderService.showLoaderUntilCompleted(instructor);
  }
  loadPhoto(): void{
    this.photoUrl$ = this.instructor$.pipe(
    tap(data => this.createDescription(data)),
    tap(data => this.workExperienceLength = data.workExperiencePerCompany.length),
    map(data => {
        return data.photo===null?`${this.photoService.uri}empty/empty-person`
                :`${this.photoService.uri}instructor/${data.photo}`;
        })
      );
  }
  loadWorkExperience(): void{
    this.workExperience$ =  this.instructor$.pipe(
      map(data => data.workExperiencePerCompany as WorkExperience[])
    );
  }
  createDescription(instructor:Instructor): void{
    this.description = this.htmlTextElementService.openParentTag(ParentTagText.span,'')
                                  .addText("I'm a")
                                  .addChild(ChildTagText.i," Driving Instructor ",'')
                                  .addChild(ChildTagText.b,`${instructor.fullname} `,'')
                                  .addText(`${instructor.age} years old with ${instructor.totalDriveExperience}
                                          years total drive experience. I have been driving
                                           as a truck driver for ${instructor.truckDriveExperience}
                                          years and my total work experience is ${instructor.totalWorkExperience} years.
                                          I finished at the driving school academy in `)
                                  .addChild(ChildTagText.b,`${instructor.instructorAcademy}`,'')
                                  .addText('. I started working in this company from year ')
                                  .addChild(ChildTagText.i,`${new Date(instructor.startedDay).getFullYear()}`,'')
                                  .addText('. Come for fellowship and learning. What to say: ')
                                  .addNewLine(false)
                                  .addChild(ChildTagText.ins,'Big Truck, Big Responsibility.','moto')
                                  .closeParentTag()
                                  .addNewLine(true)
                                  .getElements();
  }

}

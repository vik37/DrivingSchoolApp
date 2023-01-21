import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap,map, switchMap } from 'rxjs/operators';
import { ActivatedRoute,ParamMap } from '@angular/router';
import {Instructor} from 'src/app/categories/category-b/models/instructor.interface';
import {WorkExperience} from 'src/app/categories/category-b/models/work-experience.interface';
import {InstructorService} from 'src/app/categories/category-b/services/instructor.service';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {HtmlElementService} from 'src/app/shared/services/helper/html-elements-builder/html-element.service';
import {ParentTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/parent-text-tag.enum';
import {ChildTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/child-text-tag.enum';

@Component({
  selector: 'app-instructor-detail',
  templateUrl: './instructor-detail.component.html',
  styleUrls: ['../../../shared/style/instructor-detail-shared-style.css',
              './instructor-detail.component.css'],
  providers: [PhotoService, HtmlElementService]
})
export class InstructorDetailComponent implements OnInit {
  public instructor$: Observable<Instructor> = this.route.paramMap.pipe(
                      switchMap((params:ParamMap)=>{
                        const categoryBId = params.get('id' as string);
                        const instructorId = params.get('instructorId' as string);
                        return this.instructorService.getInstructorById(categoryBId??'',instructorId??'')
                      }));
  public workExperience$: Observable<WorkExperience[]> = this.instructor$.pipe(
    map(data => data.workExperiencePerCompany as WorkExperience[])
  );
  public photoUrl$!:Observable<string>;
  public description:string = '';
  public workExperienceLength:number = 0;

  constructor(private route: ActivatedRoute, private instructorService: InstructorService,
                private photoService:PhotoService,private htmlElements: HtmlElementService) { }

  ngOnInit(): void {
    this.loadPhoto();
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
  createDescription(instructor:Instructor): void{
    this.description = this.htmlElements.openParentTag(ParentTagText.span,'')
                                        .addText("I'm a")
                                        .addChild(ChildTagText.i," Driving Instructor ",'')
                                        .addChild(ChildTagText.b,`${instructor.fullname} `,'')
                                        .addText(`${instructor.age} years old with ${instructor.driveExperience} years drive experience
                                                    and ${instructor.totalWorkExperience} total work experience like instructor.
                                                    I finished at the driving school academy in `)
                                        .addChild(ChildTagText.b,`${instructor.instructorAcademy}`,'')
                                        .addText('. I started working in this company from year ')
                                        .addChild(ChildTagText.i,`${new Date(instructor.startedDay).getFullYear()}`,'')
                                        .addText('. Come for fellowship and learning. Our Moto: ')
                                        .addNewLine(false)
                                        .addChild(ChildTagText.ins,'Choose wisely, drive right.','moto')
                                        .addNewLine(true)
                                        .closeParentTag()
                                        .getElements();

  }
}

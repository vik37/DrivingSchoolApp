import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap,map, switchMap,filter } from 'rxjs/operators';
import { ActivatedRoute,ParamMap } from '@angular/router';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {WorkExperience} from 'src/app/categories/category-b/models/work-experience';
import {InstructorService} from 'src/app/categories/category-b/services/instructor.service';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {HtmlElementService} from 'src/app/shared/services/helper/html-elements-builder/html-element.service';
import {ParentTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/parent-text-tag.enum';
import {ChildTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/child-text-tag.enum';

@Component({
  selector: 'app-instructor-detail',
  templateUrl: './instructor-detail.component.html',
  styleUrls: ['./instructor-detail.component.css'],
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

  constructor(private route: ActivatedRoute, private instructorService: InstructorService,
                private photoService:PhotoService,private htmlElements: HtmlElementService) { }

  ngOnInit(): void {
    this.loadPhoto();
  }
  loadPhoto(): void{
    this.photoUrl$ = this.instructor$.pipe(
      tap(data => this.createDescription(data)),
      map(data => {
        return data.photo===null?`${this.photoService.uri}empty/empty-person`
                          :`${this.photoService.uri}instructor/${data.photo}`;
      })
    );
  }
  createDescription(instructor:Instructor): void{
    this.description = this.htmlElements.openParentTag(ParentTagText.span,'')
                                        .addText("I'm a")
                                        .AddChild(ChildTagText.i," Driving Instructor ",'')
                                        .AddChild(ChildTagText.b,`${instructor.fullname} `,'')
                                        .addText(`${instructor.age} years old with ${instructor.driveExperience} years drive experience
                                                    and ${instructor.totalWorkExperience} total work experience like instructor.
                                                    I finished at the driving school academy in `)
                                        .AddChild(ChildTagText.b,`${instructor.instructorAcademy}`,'')
                                        .addText('. I started working in this company from year ')
                                        .AddChild(ChildTagText.i,`${new Date(instructor.startedDay).getFullYear()}`,'')
                                        .addText('. Come for fellowship and learning. Our Moto: ')
                                        .AddChild(ChildTagText.ins,'Choose wisely, drive right.','moto')
                                        .closeParentTag()
                                        .getElements();

  }
}

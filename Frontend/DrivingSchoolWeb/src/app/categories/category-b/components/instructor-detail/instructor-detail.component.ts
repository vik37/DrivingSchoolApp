import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap,map, switchMap } from 'rxjs/operators';
import { ActivatedRoute,ParamMap } from '@angular/router';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {WorkExperience} from 'src/app/categories/category-b/models/work-experience';
import {InstructorService} from 'src/app/categories/category-b/services/instructor.service';
import {PhotoService} from 'src/app/shared/services/photo.service';
import { faL } from '@fortawesome/free-solid-svg-icons';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-instructor-detail',
  templateUrl: './instructor-detail.component.html',
  styleUrls: ['./instructor-detail.component.css'],
  providers: [PhotoService]
})
export class InstructorDetailComponent implements OnInit {
  public instructor$: Observable<Instructor> = this.route.paramMap.pipe(
                      switchMap((params:ParamMap)=>{
                        const categoryBId = params.get('id' as string);
                        const instructorId = params.get('instructorId' as string);
                        return this.instructorService.getInstructorById(categoryBId??'',instructorId??'')
                      }));
  public photoUrl$!:Observable<string>;
  public description:string = '';

  constructor(private route: ActivatedRoute, private instructorService: InstructorService,
                private photoService:PhotoService) { }

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
    this.description = `I'm a <i>Driving Instructor </i> <b>${instructor.fullname}</b>,
                          ${instructor.age} years old with ${instructor.driveExperience} years drive experience
                          and ${instructor.totalWorkExperience} total work experience like instructor.
                          I finished at the driving school academy in <b>${instructor.instructorAcademy}</b>.
                          I started working in this company from
                            <i>${new Date(instructor.startedDay).getFullYear()} year</i>.
                          Come for fellowship and learning. Our Moto: Choose wisely, drive right."`
                        console.log(this.description)
  }
}

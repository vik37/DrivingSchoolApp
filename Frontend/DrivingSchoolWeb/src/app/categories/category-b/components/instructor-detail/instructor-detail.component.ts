import { Component, OnInit } from '@angular/core';
import { Observable,Subject } from 'rxjs';
import { tap,map, switchMap } from 'rxjs/operators';
import { ActivatedRoute,ParamMap } from '@angular/router';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {WorkExperience} from 'src/app/categories/category-b/models/work-experience';
import {InstructorService} from 'src/app/categories/category-b/services/instructor.service';
import {PhotoService} from 'src/app/shared/services/photo.service';

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
  public asyncPhoto$!:Observable<string>;

  constructor(private route: ActivatedRoute, private instructorService: InstructorService,
                private photoService:PhotoService) { }

  ngOnInit(): void {
    this.loadPhoto();
  }
  loadPhoto(): void{
    this.asyncPhoto$ = this.instructor$.pipe(
      map(data => {
        return data.photo===null?`${this.photoService.uri}empty/empty-person`
                          :`${this.photoService.uri}instructor/${data.photo}`;
      })
    );
  }
}

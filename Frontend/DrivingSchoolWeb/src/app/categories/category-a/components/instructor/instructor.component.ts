import { Component,OnChanges,SimpleChanges,Input,AfterViewInit } from '@angular/core';
import {Instructor} from 'src/app/categories/category-a/models/instructor';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {faUserCheck} from '@fortawesome/free-solid-svg-icons';

declare var jQuery: any;

@Component({
  selector: 'app-instructor',
  templateUrl: './instructor.component.html',
  styleUrls: ['../../../shared/style/instructor-style.css',
              './instructor.component.css'],
  providers: [PhotoService]
})
export class InstructorComponent implements OnChanges, AfterViewInit {
  photoUrl: string = '';
  faUserCheck = faUserCheck;
  @Input() instructor: Instructor | undefined;
  constructor(private photoService: PhotoService) { }
  ngOnChanges(changes: SimpleChanges): void{
    let firstInstructorChanges = changes['instructor'];
    if(firstInstructorChanges.firstChange){
      if(this.instructor?.photo === null){
        this.photoUrl = `${this.photoService.uri}empty/empty-person`;
      }
      else{
        this.photoUrl = `${this.photoService.uri}instructor/${this.instructor?.photo}`;
      }
    }
  }
  ngAfterViewInit(): void {
    jQuery('[data-bs-toggle="tooltip"]').tooltip({
      title: `book an ${this.instructor?.fullname}`
    });
  }
}

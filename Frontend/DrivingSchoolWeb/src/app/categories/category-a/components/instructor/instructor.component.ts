import { Component,OnChanges,SimpleChanges,Input } from '@angular/core';
import {Instructor} from 'src/app/categories/category-a/models/instructor';
import {PhotoService} from 'src/app/shared/services/photo.service';


@Component({
  selector: 'app-instructor',
  templateUrl: './instructor.component.html',
  styleUrls: ['./instructor.component.css'],
  providers: [PhotoService]
})
export class InstructorComponent implements OnChanges {
  photoUrl: string = '';
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
}

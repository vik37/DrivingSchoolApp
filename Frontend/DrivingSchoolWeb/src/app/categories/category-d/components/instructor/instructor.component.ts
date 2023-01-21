import { Component,OnChanges,SimpleChanges,Input,AfterViewInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {Instructor} from 'src/app/categories/category-d/models/instructor.interface';
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
export class InstructorComponent implements OnChanges {

  public photoUrl: string = '';
  public faUserCheck = faUserCheck;
  public categoryCId:string | null = null;
  @Input() instructor: Instructor | undefined;

  constructor(private photoService: PhotoService,private route: ActivatedRoute) { }

  ngOnChanges(changes: SimpleChanges): void{
    let instructorChanges = changes['instructor'];
    if(instructorChanges.firstChange){
      if(this.instructor?.photo === null){
        this.photoUrl = `${this.photoService.uri}empty/empty-person`;
        this.categoryCId = this.route.snapshot.paramMap.get('id');
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

import { Component, OnChanges, SimpleChanges, Input } from '@angular/core';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle';
import {PhotoService} from 'src/app/shared/services/photo.service';


@Component({
  selector: 'app-motorcycle-detail',
  templateUrl: './motorcycle-detail.component.html',
  styleUrls: ['./motorcycle-detail.component.css']
})
export class MotorcycleDetailComponent implements OnChanges {

  photoUrl:string = '';
  @Input()motorcycle: Motorcycle | undefined;
  constructor(private photoService: PhotoService) { }

  ngOnChanges(changes: SimpleChanges): void {
    let motorcycleChanges = changes['motorcycle'];

    console.log('simple change: ', motorcycleChanges)
    if(!motorcycleChanges.firstChange){
      this.photoUrl = this.photoService.uri + "motorcycles/" + this.motorcycle!.photo;
      console.log(this.photoUrl)
    }
  }

}

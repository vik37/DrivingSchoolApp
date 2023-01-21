import { Component,Input } from '@angular/core';
import {Car} from 'src/app/categories/category-b/models/car.interface';
import {PhotoService} from 'src/app/shared/services/photo.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css',
              '../../../shared/style/vehicle-detail-style.css'],
  providers: [PhotoService]
})
export class CarDetailComponent {

  private _car!: Car;
  photoUrl:string = '';

  constructor(private photoService: PhotoService) { }
  @Input()
  set car(value:Car){
    if(value){
      this._car = value;
      this.photoUrl = this.photoService.uri + "cars/" + value.photo;
    }
  };
  get car(): Car{
    return this._car;
  }
}

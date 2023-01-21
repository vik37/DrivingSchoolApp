import { Component, Input,AfterViewInit } from '@angular/core';
import {Car} from 'src/app/categories/category-b/models/car.interface';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {faCar} from '@fortawesome/free-solid-svg-icons';
declare var jQuery: any;

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css',
              '../../../shared/style/vehicle-style.css'],
  providers: [PhotoService]
})
export class CarComponent implements AfterViewInit {
  private _car!: Car;
  photoUrl:string = '';
  faCar = faCar;

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
  ngAfterViewInit(): void {
    jQuery('[data-bs-toggle="tooltip"]').tooltip({
      title: `book an ${this.car?.type}`
    });
  }
}

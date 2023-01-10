import { Component, Input,AfterViewInit, ChangeDetectionStrategy } from '@angular/core';
import {Car} from 'src/app/categories/category-b/models/car';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {faMotorcycle} from '@fortawesome/free-solid-svg-icons';
declare var jQuery: any;

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css','../../../shared/style/vehicle.css'],
  providers: [PhotoService],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CarComponent implements AfterViewInit {
  private _car!: Car;

  photoUrl:string = '';
  faMotorcycle = faMotorcycle;

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
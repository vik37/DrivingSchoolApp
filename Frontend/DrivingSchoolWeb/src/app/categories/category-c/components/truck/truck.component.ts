import { Component, Input,AfterViewInit } from '@angular/core';
import {Truck} from 'src/app/categories/category-c/models/truck';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {faTruck} from '@fortawesome/free-solid-svg-icons';
declare var jQuery: any;

@Component({
  selector: 'app-truck',
  templateUrl: './truck.component.html',
  styleUrls: ['./truck.component.css','../../../shared/style/vehicle.css']
})
export class TruckComponent implements AfterViewInit {
  private _truck!: Truck;
  photoUrl:string = '';
  faTruck = faTruck;

  constructor(private photoService: PhotoService) { }

  @Input()
  set car(value:Truck){
    if(value){
      this._truck = value;
      this.photoUrl = this.photoService.uri + "trucks/" + value.photo;
    }
  };
  get truck(): Truck{
    return this._truck;
  }
  ngAfterViewInit(): void {
    jQuery('[data-bs-toggle="tooltip"]').tooltip({
      title: `book an ${this.truck?.type}`
    });
  }
}

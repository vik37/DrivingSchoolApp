import { Component,Input } from '@angular/core';
import {Truck} from 'src/app/categories/category-c/models/truck.interface';
import {PhotoService} from 'src/app/shared/services/photo.service';
@Component({
  selector: 'app-truck-detail',
  templateUrl: './truck-detail.component.html',
  styleUrls: ['./truck-detail.component.css',
              '../../../shared/style/vehicle-detail-style.css'],
  providers:[PhotoService]
})
export class TruckDetailComponent {

  private _truck!: Truck;
  photoUrl:string = '';

  constructor(private photoService: PhotoService) { }
  @Input()
  set truck(value:Truck){
    if(value){
      this._truck = value;
      this.photoUrl = this.photoService.uri + "trucks/" + value.photo;
    }
  };
  get truck(): Truck{
    return this._truck;
  }
}

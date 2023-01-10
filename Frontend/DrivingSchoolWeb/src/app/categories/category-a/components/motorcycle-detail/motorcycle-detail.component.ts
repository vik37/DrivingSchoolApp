import { Component, Input } from '@angular/core';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle';
import {PhotoService} from 'src/app/shared/services/photo.service';


@Component({
  selector: 'app-motorcycle-detail',
  templateUrl: './motorcycle-detail.component.html',
  styleUrls: ['./motorcycle-detail.component.css','../../../shared/style/vehicle-detail.css'],
  providers:[PhotoService]
})
export class MotorcycleDetailComponent {

  private _motorcycle!: Motorcycle;
  photoUrl:string = '';

  constructor(private photoService: PhotoService) { }

  @Input()
  set motorcycle(value:Motorcycle){
    if(value){
      this._motorcycle = value;
      this.photoUrl = this.photoService.uri + "motorcycles/" + value.photo;
    }
  };
  get motorcycle(): Motorcycle{
    return this._motorcycle;
  }
}

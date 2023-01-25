import { Component,Input,AfterViewInit } from '@angular/core';
import { faMotorcycle } from '@fortawesome/free-solid-svg-icons';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle.interface';
import {PhotoService} from 'src/app/shared/services/photo.service';
declare var jQuery: any;

@Component({
  selector: 'app-motorcycle',
  templateUrl: './motorcycle.component.html',
  styleUrls: ['./motorcycle.component.css','../../../shared/style/vehicle-style.css'],
  providers: [PhotoService]
})
export class MotorcycleComponent implements AfterViewInit {

  private _motorcycle!: Motorcycle;
  public photoUrl: string = '';
  public faMotorcycle = faMotorcycle;

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

  ngAfterViewInit(): void {
    jQuery('[data-bs-toggle="tooltip"]').tooltip({
      title: `book an ${this.motorcycle?.type}`
    });
  }

}

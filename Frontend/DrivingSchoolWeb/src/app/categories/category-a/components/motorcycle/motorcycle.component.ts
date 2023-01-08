import { Component, OnChanges, SimpleChanges, Input,AfterViewInit, ChangeDetectionStrategy } from '@angular/core';
import {Motorcycle} from 'src/app/categories/category-a/models/motorcycle';
import {PhotoService} from 'src/app/shared/services/photo.service';
import {faMotorcycle} from '@fortawesome/free-solid-svg-icons';
declare var jQuery: any;

@Component({
  selector: 'app-motorcycle',
  templateUrl: './motorcycle.component.html',
  styleUrls: ['./motorcycle.component.css'],
  providers: [PhotoService],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class MotorcycleComponent implements OnChanges, AfterViewInit {
  private _motorcycle!: Motorcycle;
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
  photoUrl:string = '';
  faMotorcycle = faMotorcycle;

  constructor(private photoService: PhotoService) { }

  ngOnChanges(changes: SimpleChanges): void {
    //let motorcycleChanges = changes['motorcycle'];
    //if(motorcycleChanges.firstChange){
    //  this.photoUrl = this.photoService.uri + "motorcycles/" + this.motorcycle?.photo;
    //}
  }
  ngAfterViewInit(): void {
    jQuery('[data-bs-toggle="tooltip"]').tooltip({
      title: `book an ${this.motorcycle?.type}`
    });
  }
}

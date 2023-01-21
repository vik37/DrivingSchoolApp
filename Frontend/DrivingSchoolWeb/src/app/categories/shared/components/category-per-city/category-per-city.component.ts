import { Component, Input } from '@angular/core';
import {Category} from 'src/app/categories/shared/models/category.interface';
import { faPhone } from '@fortawesome/free-solid-svg-icons';
import {PhotoService} from 'src/app/shared/services/photo.service';

@Component({
  selector: 'app-category-per-city',
  templateUrl: './category-per-city.component.html',
  styleUrls: ['./category-per-city.component.css'],
  providers:[PhotoService]
})
export class CategoryPerCityComponent {
  private _category!: Category | null;
  public photoUrl: string = '';
  faPhone = faPhone;
  constructor(private photoService: PhotoService) { }
  @Input() set category(value:Category | null){
    if(value){
      this._category = value;
      this.photoUrl = this.photoService.uri+'city/'+value.city.toLowerCase();
    }
  }
  get category(): Category | null{
    return this._category;
  }
}

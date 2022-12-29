import { Component, OnChanges, SimpleChanges, Input } from '@angular/core';
import {Category} from 'src/app/categories/shared/models/category';
import { faPhone } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-category-per-city',
  templateUrl: './category-per-city.component.html',
  styleUrls: ['./category-per-city.component.css']
})
export class CategoryPerCityComponent implements OnChanges {

  @Input()category: Category | null = null;
  @Input()photoUrl: string = '';
  faPhone = faPhone;
  constructor() { }
  ngOnChanges(changes: SimpleChanges): void{

  }
}

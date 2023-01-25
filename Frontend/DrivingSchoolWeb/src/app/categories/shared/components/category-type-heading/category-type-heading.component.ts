import { Component, Input } from '@angular/core';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

@Component({
  selector: 'app-category-type-heading',
  templateUrl: './category-type-heading.component.html',
  styleUrls: ['./category-type-heading.component.css']
})
export class CategoryTypeHeadingComponent{

  public categoryType = CategoryType;
  private _categoryTypeHeading!: CategoryType;

  constructor() { }

  @Input()
  set categoryTypeHeading(value: CategoryType){
      this._categoryTypeHeading = value;
  };
  get categoryTypeHeading(): CategoryType{
    return this._categoryTypeHeading;
  }

}

import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC.interface';
import {CategoryCService} from 'src/app/categories/category-c/services/category-c.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

@Component({
  selector: 'app-category-c',
  templateUrl: './category-c.component.html',
  styleUrls: ['../../../shared/style/category-style.css','./category-c.component.css']
})
export class CategoryCComponent {
  public categoryTypeHeading: CategoryType = CategoryType.C;
  categoryCRoute:string = 'category-c';
  categoryC$: Observable<CategoryC[]> = this.categoryCService.getAll();
  constructor(private categoryCService: CategoryCService) { }
}

import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB.interface';
import {CategoryBService} from 'src/app/categories/category-b/services/category-b.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

@Component({
  selector: 'app-category-b',
  templateUrl: './category-b.component.html',
  styleUrls: ['../../../shared/style/category-style.css','./category-b.component.css']
})
export class CategoryBComponent {
  public categoryTypeHeading: CategoryType = CategoryType.B;
  public categoryBRoute:string = 'category-b';
  public categoryB$: Observable<CategoryB[]> = this.categoryBService.getAll();

  constructor(private categoryBService: CategoryBService) { }

}

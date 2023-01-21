import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryAService} from 'src/app/categories/category-a/services/category-a.service';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA.interface';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

@Component({
  selector: 'app-category-a',
  templateUrl: './category-a.component.html',
  styleUrls: ['../../../shared/style/category-style.css','./category-a.component.css']
})
export class CategoryAComponent {
  public categoryTypeHeading: CategoryType = CategoryType.A;
  public categoryARoute:string = 'category-a';
  public categoryA$: Observable<CategoryA[]> = this.categoryAService.getAll();

  constructor(private categoryAService: CategoryAService) { }

}

import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB';
import {CategoryBService} from 'src/app/categories/category-b/services/category-b.service';

@Component({
  selector: 'app-category-b',
  templateUrl: './category-b.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-b.component.css']
})
export class CategoryBComponent {
  public categoryBRoute:string = 'category-b';
  public categoryB$: Observable<CategoryB[]> = this.categoryBService.getAll();

  constructor(private categoryBService: CategoryBService) { }

}

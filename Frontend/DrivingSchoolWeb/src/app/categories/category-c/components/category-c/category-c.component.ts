import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC';
import {CategoryCService} from 'src/app/categories/category-c/services/category-c.service';
@Component({
  selector: 'app-category-c',
  templateUrl: './category-c.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-c.component.css']
})
export class CategoryCComponent {
  categoryCRoute:string = 'category-c';
  categoryC$: Observable<CategoryC[]> = this.categoryCService.getAll();
  constructor(private categoryCService: CategoryCService) { }
}

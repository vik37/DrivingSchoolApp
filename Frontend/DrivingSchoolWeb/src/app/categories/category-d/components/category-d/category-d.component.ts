import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD';
import {CategoryDService} from 'src/app/categories/category-d/services/category-d.service';

@Component({
  selector: 'app-category-d',
  templateUrl: './category-d.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-d.component.css']
})
export class CategoryDComponent {
  categoryDRoute: string = 'category-d';
  categoryD$: Observable<CategoryD[]> = this.categoryDService.getAll();

  constructor(private categoryDService: CategoryDService) { }

}

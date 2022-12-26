import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

import {CategoryAService} from 'src/app/categories/category-a/services/category-a.service';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA';

@Component({
  selector: 'app-category-a',
  templateUrl: './category-a.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-a.component.css']
})
export class CategoryAComponent {

  categoryA$: Observable<CategoryA[]> = this.categoryAService.getAll();

  constructor(private categoryAService: CategoryAService, private router: Router) { }
  
  navigateToCategoryADetails(id:number){
    this.router.navigate([`category-a/${id}`])
  }

}

import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD';
import {CategoryDService} from 'src/app/categories/category-d/services/category-d.service';

@Component({
  selector: 'app-category-d',
  templateUrl: './category-d.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-d.component.css']
})
export class CategoryDComponent implements OnInit, OnDestroy {

  private categoryDSubscription: Subscription = new Subscription();
  categoryD: CategoryD[] = []
  constructor(private categoryDService: CategoryDService) { }

  ngOnInit(): void {
    this.categoryDSubscription.add(this.categoryDService.get().subscribe(data => {
      this.categoryD = data
    }));
  }
  ngOnDestroy(): void {
    this.categoryDSubscription.unsubscribe();
  }
}

import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC';
import {CategoryCService} from 'src/app/categories/category-c/services/category-c.service';
@Component({
  selector: 'app-category-c',
  templateUrl: './category-c.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-c.component.css']
})
export class CategoryCComponent implements OnInit, OnDestroy {

  private categoryCSubscription: Subscription = new Subscription();
  categoryC: CategoryC[] = [];

  constructor(private categoryCService: CategoryCService) { }

  ngOnInit(): void {
    this.categoryCSubscription = this.categoryCService.get().subscribe(data => {
      this.categoryC = data
    })
  }
  ngOnDestroy(): void {
    this.categoryCSubscription.unsubscribe();
  }
}

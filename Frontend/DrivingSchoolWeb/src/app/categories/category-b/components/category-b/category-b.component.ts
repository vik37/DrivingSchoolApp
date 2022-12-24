import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB';
import {CategoryBService} from 'src/app/categories/category-b/services/category-b.service';

@Component({
  selector: 'app-category-b',
  templateUrl: './category-b.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-b.component.css']
})
export class CategoryBComponent implements OnInit, OnDestroy {

  private categoryBSubscription: Subscription = new Subscription();
  categoryB: CategoryB[] = [];

  constructor(private categoryBService: CategoryBService) { }

  ngOnInit(): void {
    this.categoryBSubscription = this.categoryBService.getAll().subscribe(data => {
      this.categoryB = data
    })
  }
  ngOnDestroy(): void {
    this.categoryBSubscription.unsubscribe();
  }
}

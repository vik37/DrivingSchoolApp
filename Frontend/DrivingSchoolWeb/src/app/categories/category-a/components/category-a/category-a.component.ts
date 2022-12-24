import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';

import {CategoryAService} from 'src/app/categories/category-a/services/category-a.service';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA';

@Component({
  selector: 'app-category-a',
  templateUrl: './category-a.component.html',
  styleUrls: ['../../../shared/style/category.css','./category-a.component.css']
})
export class CategoryAComponent implements OnInit, OnDestroy {
  categoryA:CategoryA[] =[];
  private categoryASubscription: Subscription = new Subscription();
  constructor(private categoryAService: CategoryAService) { }

  ngOnInit(): void {
    this.categoryASubscription = this.categoryAService.getAll().subscribe(data =>{
      console.log(data);
      this.categoryA = data;
    });
  }
  ngOnDestroy(): void {
    this.categoryASubscription.unsubscribe();
  }
}

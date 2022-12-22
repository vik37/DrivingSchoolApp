import { Component,OnInit,OnChanges,SimpleChanges } from '@angular/core';
import { Subscription } from 'rxjs';
import {Category} from 'src/app/categories/shared/models/category';
import {PhotoService} from 'src/app/shared/services/photo.service';

@Component({
  selector: 'app-category-card',
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.css']
})
export class CategoryCardComponent implements OnInit, OnChanges {
  private photoSubscription: Subscription = new Subscription();
  constructor(private photoService:PhotoService) { }
  image:string = "";
  ngOnInit(): void {
    this.image = this.photoService.uri;
  }
  ngOnChanges(changes: SimpleChanges): void{

  }
}

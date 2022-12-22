import { Component,OnInit,OnChanges,SimpleChanges,Input } from '@angular/core';
import { Subscription } from 'rxjs';
import { faPhone } from '@fortawesome/free-solid-svg-icons';
import {Category} from 'src/app/categories/shared/models/category';
import {PhotoService} from 'src/app/shared/services/photo.service';

@Component({
  selector: 'app-category-card',
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.css']
})
export class CategoryCardComponent implements OnInit, OnChanges {
  private photoSubscription: Subscription = new Subscription();
  @Input()category:Category | null = null;
  faPhone = faPhone;
  constructor(private photoService:PhotoService) { }
  image:string = "";
  ngOnInit(): void {

  }
  ngOnChanges(changes: SimpleChanges): void{
    let firstCategoryChanges = changes['category'];
    if(firstCategoryChanges.firstChange){
      this.image = `${this.photoService.uri}city/${this.category?.city.toLowerCase()}`;
      console.log('check photo url',this.image);
    }
  }
}

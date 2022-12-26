import { Component,OnChanges,SimpleChanges,Input,Output,EventEmitter } from '@angular/core';
import { faPhone } from '@fortawesome/free-solid-svg-icons';
import {Category} from 'src/app/categories/shared/models/category';
import {PhotoService} from 'src/app/shared/services/photo.service';

@Component({
  selector: 'app-category-card',
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.css']
})
export class CategoryCardComponent implements OnChanges {

  @Input()category:Category | null = null;
  @Output()idEmmiter:EventEmitter<number> = new EventEmitter<number>();
  faPhone = faPhone;
  constructor(private photoService:PhotoService) { }
  image:string = "";

  ngOnChanges(changes: SimpleChanges): void{
    let firstCategoryChanges = changes['category'];
    if(firstCategoryChanges.firstChange){
      this.image = `${this.photoService.uri}city/${this.category?.city.toLowerCase()}`;
      console.log('check photo url',this.image);
    }
  }

  sendId(id:number): void{
    this.idEmmiter.emit(id);
  }
}

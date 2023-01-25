import { Component,OnChanges,SimpleChanges,Input } from '@angular/core';
import { faPhone } from '@fortawesome/free-solid-svg-icons';
import {Category} from 'src/app/categories/shared/models/category.interface';
import {PhotoService} from 'src/app/shared/services/photo.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-category-card',
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.css'],
  providers:[PhotoService]
})
export class CategoryCardComponent implements OnChanges {

  @Input()category:Category | null = null;
  @Input()categoryRoute: string = '';
  public faPhone = faPhone;
  image:string = "";

  constructor(private photoService:PhotoService,private router: Router) { }

  ngOnChanges(changes: SimpleChanges): void{
    let categoryChanges = changes['category'];
    if(categoryChanges.firstChange){
      this.image = `${this.photoService.uri}city/${this.category?.city.toLowerCase()}`;
    }
  }
  categoryDetailNavigation(id:number): void{
    if(this.categoryRoute !== '')
    this.router.navigate([`${this.categoryRoute}/${id}`]);
  }

}

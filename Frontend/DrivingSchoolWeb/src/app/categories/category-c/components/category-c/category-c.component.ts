import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC.interface';
import {CategoryCService} from 'src/app/categories/category-c/services/category-c.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';

@Component({
  selector: 'app-category-c',
  templateUrl: './category-c.component.html',
  styleUrls: ['../../../shared/style/category-style.css','./category-c.component.css']
})
export class CategoryCComponent {

  public categoryTypeHeading: CategoryType = CategoryType.C;
  public categoryCRoute:string = 'category-c';
  private _categoryC$: Observable<CategoryC[]> = this.categoryCService.getAll();
  public categoryCLoaded$: Observable<CategoryC[]> =
                          this.loadingService.showLoaderUntilCompleted(this._categoryC$);

  constructor(private categoryCService: CategoryCService,
    private loadingService: LoadingService) { }

}

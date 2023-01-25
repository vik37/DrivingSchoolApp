import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD.interface';
import {CategoryDService} from 'src/app/categories/category-d/services/category-d.service';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';
import {LoadingService} from 'src/app/shared/services/loading.service';

@Component({
  selector: 'app-category-d',
  templateUrl: './category-d.component.html',
  styleUrls: ['../../../shared/style/category-style.css'
              ,'./category-d.component.css']
})
export class CategoryDComponent {

  public categoryTypeHeading: CategoryType = CategoryType.D;
  public categoryDRoute: string = 'category-d';
  private _categoryD$: Observable<CategoryD[]> = this.categoryDService.getAll();
  public categoryDLoaded$: Observable<CategoryD[]> =
                          this.loadingService.showLoaderUntilCompleted(this._categoryD$);

  constructor(private categoryDService: CategoryDService,
    private loadingService: LoadingService) { }

}

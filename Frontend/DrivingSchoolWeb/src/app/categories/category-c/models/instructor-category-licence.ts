import {Base} from 'src/app/categories/shared/models/base';
import {CategoryType} from 'src/app/categories/category-c/models/enums/category-type';

export interface InstructorCategoryLicence extends Base{
  categoryType:CategoryType;
}

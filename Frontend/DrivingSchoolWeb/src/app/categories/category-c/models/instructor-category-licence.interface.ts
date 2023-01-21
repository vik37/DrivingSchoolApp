import {Base} from 'src/app/categories/shared/models/base.interface';
import {CategoryType} from 'src/app/categories/shared/models/enums/category-type.enum';

export interface InstructorCategoryLicence extends Base{
  categoryType:CategoryType;
}

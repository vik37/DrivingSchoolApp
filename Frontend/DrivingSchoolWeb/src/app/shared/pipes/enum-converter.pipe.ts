import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'enumConverter'
})
export class EnumConverterPipe implements PipeTransform {

  transform(value: number, enumProp: any): any {
    return Object.values(enumProp)[value];
  }

}

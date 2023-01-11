import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'convertEnumToArray'
})
export class ConvertEnumToArrayPipe implements PipeTransform {
  transform(value: any): any{
    let result = [];
    const keys = Object.keys(value);
    const values = Object.values(value);
    for(let i = 0;i < keys.length;i++){
      result.push({key: keys[i], value: values[i]})
    }
    return result.slice(keys.length / 2);
  }
}

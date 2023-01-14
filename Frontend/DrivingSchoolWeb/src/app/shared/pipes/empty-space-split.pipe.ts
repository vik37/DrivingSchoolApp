import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'emptySpaceSplit'
})
// returns a specific string by index or the whole array if index is negative number
// or less then 0.
export class EmptySpaceSplitPipe implements PipeTransform {
  transform(value: string, index:number): string | string[] {
    const splitted = value.split(' ');
    let result = '';
    if(index >= 0){
      result = splitted.find(x => x.at(index))??'';
    }
    return index>=0?result:splitted;
  }
}

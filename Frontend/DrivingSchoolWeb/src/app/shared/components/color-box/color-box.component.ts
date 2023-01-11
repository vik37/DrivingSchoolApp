import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-color-box',
  templateUrl: './color-box.component.html',
  styleUrls: ['./color-box.component.css']
})
export class ColorBoxComponent implements OnChanges {
  @Input() colorText: string = '';
  colors:string[] = [];
  constructor() { }

  ngOnChanges(changes: SimpleChanges): void {
    if(changes['colorText'].firstChange){
      this.colors = this.colorText.split("&").map(color => color.trim().toLowerCase());
    }
  }

}

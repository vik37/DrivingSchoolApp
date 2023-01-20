import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-color-box',
  template: `
      <div *ngIf="colorText !== ''" class="color-box-block">
        <div class="row">
          <div class="col-xs-5 col-sm-12 col-md-5">
            <p class="color-text">Colors:</p>
          </div>
          <div class="col-xs-7 col-sm-12 col-md-7">
            <div class="row">
              <div *ngFor="let color of colors" class="col-2">
                <div class="color-box" [ngStyle]="{'background-color':color === 'metalic'?'#C3CDE6':color}"></div>
              </div>
            </div>
          </div>
        </div>
      </div>
  `,
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

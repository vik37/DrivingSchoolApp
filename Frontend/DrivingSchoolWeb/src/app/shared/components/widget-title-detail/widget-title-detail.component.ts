import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-widget-title-detail',
  template: `
      <div class="widget-title">
        <div class="widget-title-header">
          <div class="widget-title-image-block">
            <ng-content select=".widget-title-image"></ng-content>
          </div>
          <div>
            <ng-content select=".widget-title-title"></ng-content>
          </div>
          <div>
            <ng-content select=".widget-title-subtitle"></ng-content>
          </div>
        </div>
        <br />
        <hr />
        <div class="widget-title-body">
          <div class="widget-title-body-description-block">
            <ng-content select="h6"></ng-content>
            <p [innerHTML]="descriptionHTMLText"></p>
          </div>
        </div>
      </div>
  `,
  styleUrls: ['./widget-title-detail.component.css']
})
export class WidgetTitleDetailComponent {
  private _descriptionHTMLText:string = '';
  constructor() { }
  @Input('description')
  set descriptionHTMLText(value: string){
      if(value){
        this._descriptionHTMLText = value;
      }
  }
  get descriptionHTMLText(): string{
    return this._descriptionHTMLText;
  }
}

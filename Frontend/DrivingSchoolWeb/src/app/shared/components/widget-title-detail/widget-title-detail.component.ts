import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-widget-title-detail',
  templateUrl: './widget-title-detail.component.html',
  styleUrls: ['./widget-title-detail.component.css']
})
export class WidgetTitleDetailComponent {
  private _descriptionHTMLText:string = '';
  private _additionalCheck:boolean = false;
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
  @Input() set additionalCheck(value:boolean){
    this._additionalCheck = value;
  }
  get additionalCheck(): boolean{
    return this._additionalCheck;
  }

}

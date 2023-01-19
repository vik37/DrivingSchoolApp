import {ParentTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/parent-text-tag.enum';

export class HtmlBuilderTagsService {
  public htmlElements: string[] = [];
  public fullHtmlText:string = '';

  constructor() { }
  CreateHtmlElements(tag:ParentTagText): void{
    for(let i = 0;i < this.htmlElements.length;i++){
      if(this.htmlElements[i].includes('</p>') || this.htmlElements[i].includes('</span>')){
        this.fullHtmlText += this.htmlElements[i];
        this.fullHtmlText += '\n';
      }
      else{
        this.fullHtmlText += this.htmlElements[i];
      }
    }
    if(!this.htmlElements.at(this.htmlElements.length-1)?.includes(`</${tag}>`)){
      this.fullHtmlText += `</${tag}>`;
    }
  }
}

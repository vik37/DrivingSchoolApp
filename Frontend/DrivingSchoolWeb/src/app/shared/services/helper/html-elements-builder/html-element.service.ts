import { Injectable } from '@angular/core';
import {HtmlBuilderTagsService} from 'src/app/shared/services/helper/html-elements-builder/html-builder-tags.service';
import {ParentTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/parent-text-tag.enum';
import {ChildTagText} from 'src/app/shared/services/helper/html-elements-builder/enums/child-text-tag.enum';

@Injectable()
export class HtmlElementService {

  private parentTag!: ParentTagText;
  private htmlBuilderTagsService:HtmlBuilderTagsService = new HtmlBuilderTagsService();
  constructor() { }

  openParentTag(tag:ParentTagText, className:string): HtmlElementService{
    this.parentTag = tag;
    if(className !== ''){
      this.htmlBuilderTagsService.htmlElements.push(`<${tag} class="${className}">`);
      return this;
    }
    this.htmlBuilderTagsService.htmlElements.push(`<${tag}>`);
    return this;
  }
  closeParentTag(): HtmlElementService{
    this.htmlBuilderTagsService.htmlElements.push(`</${this.parentTag}>`);
    return this;
  }
  addText(text:string): HtmlElementService{
    this.htmlBuilderTagsService.htmlElements.push(text);
    return this;
  }
  addChild(tag:ChildTagText,text:string,className:string): HtmlElementService{
    if(className !== ''){
      this.htmlBuilderTagsService.htmlElements.push(`<${tag} class="${className}">${text}</${tag}>`);
      return this;
    }
    this.htmlBuilderTagsService.htmlElements.push(`<${tag}>${text}</${tag}>`)
    return this;
  }
  addNewLine(showLine:boolean): HtmlElementService{
    showLine?this.htmlBuilderTagsService.htmlElements.push("<hr />"):this.htmlBuilderTagsService.htmlElements.push("<br />");
    return this;
  }
  getElements(): string{
    this.htmlBuilderTagsService.CreateHtmlElements(this.parentTag);
    return this.htmlBuilderTagsService.fullHtmlText;;
  }
}

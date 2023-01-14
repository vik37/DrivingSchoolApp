import { Directive, ElementRef, HostListener,Renderer2 } from '@angular/core';

@Directive({
  selector: '[appChangeRotationButtons]'
})
export class ChangeRotationButtonsDirective{

  constructor(private element: ElementRef, private renderer: Renderer2) { }

  @HostListener('click') divClick(){
    this.changeOnClick("rgb(96, 217, 250)",0);
  }

  private changeOnClick(color: string, rotationZ:number){
    this.renderer.setStyle(this.element.nativeElement,'box-shadow',`0 0 10px 4px ${color}`)
    this.renderer.setStyle(this.element.nativeElement,'transform',`rotateZ(${rotationZ}deg)`)
  }
}

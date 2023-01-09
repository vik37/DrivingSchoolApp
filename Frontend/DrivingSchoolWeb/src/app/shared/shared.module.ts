import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from './components/card/card.component';
import { OffcanvasComponent } from './components/offcanvas/offcanvas.component';
import { ColorBoxComponent } from './components/color-box/color-box.component';



@NgModule({
  declarations: [
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent
  ]
})
export class SharedModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from './components/card/card.component';
import { OffcanvasComponent } from './components/offcanvas/offcanvas.component';



@NgModule({
  declarations: [
    CardComponent,
    OffcanvasComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[CardComponent,OffcanvasComponent]
})
export class SharedModule { }

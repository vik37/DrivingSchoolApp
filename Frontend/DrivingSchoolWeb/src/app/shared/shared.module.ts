import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from './components/card/card.component';
import { OffcanvasComponent } from './components/offcanvas/offcanvas.component';
import { ColorBoxComponent } from './components/color-box/color-box.component';
import { EnumConverterPipe } from './pipes/enum-converter.pipe';
import { ConvertEnumToArrayPipe } from './pipes/convert-enum-to-array.pipe';



@NgModule({
  declarations: [
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe
  ]
})
export class SharedModule { }

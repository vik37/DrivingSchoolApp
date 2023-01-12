import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from './components/card/card.component';
import { OffcanvasComponent } from './components/offcanvas/offcanvas.component';
import { ColorBoxComponent } from './components/color-box/color-box.component';
import { EnumConverterPipe } from './pipes/enum-converter.pipe';
import { ConvertEnumToArrayPipe } from './pipes/convert-enum-to-array.pipe';
import { ChangeRotationButtonsDirective } from './directives/changeRotationButtons';



@NgModule({
  declarations: [
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe,
    ChangeRotationButtonsDirective
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe,
    ChangeRotationButtonsDirective
  ]
})
export class SharedModule { }

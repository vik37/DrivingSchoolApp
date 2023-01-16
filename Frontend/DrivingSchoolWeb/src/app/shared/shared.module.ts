import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardComponent } from './components/card/card.component';
import { OffcanvasComponent } from './components/offcanvas/offcanvas.component';
import { ColorBoxComponent } from './components/color-box/color-box.component';
import { EnumConverterPipe } from './pipes/enum-converter.pipe';
import { ConvertEnumToArrayPipe } from './pipes/convert-enum-to-array.pipe';
import { ChangeRotationButtonsDirective } from './directives/changeRotationButtons';
import { EmptySpaceSplitPipe } from './pipes/empty-space-split.pipe';
import { WidgetTitleDetailComponent } from './components/widget-title-detail/widget-title-detail.component';
@NgModule({
  declarations: [
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe,
    ChangeRotationButtonsDirective,
    EmptySpaceSplitPipe,
    WidgetTitleDetailComponent
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
    EmptySpaceSplitPipe,
    ChangeRotationButtonsDirective,
    WidgetTitleDetailComponent
  ]
})
export class SharedModule { }

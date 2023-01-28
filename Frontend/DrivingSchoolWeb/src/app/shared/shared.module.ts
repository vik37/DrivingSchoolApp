import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {CardComponent} from './components/card/card.component';
import {OffcanvasComponent} from 'src/app/shared/components/offcanvas/offcanvas.component';
import {ColorBoxComponent} from 'src/app/shared/components/color-box/color-box.component';
import {WidgetTitleDetailComponent} from 'src/app/shared/components/widget-title-detail/widget-title-detail.component';
import {EnumConverterPipe} from 'src/app/shared/pipes/enum-converter.pipe';
import {ConvertEnumToArrayPipe} from 'src/app/shared/pipes/convert-enum-to-array.pipe';
import {EmptySpaceSplitPipe} from 'src/app/shared/pipes/empty-space-split.pipe';
import {ChangeRotationButtonsDirective} from 'src/app/shared/directives/changeRotationButtons';
import {CertificateComponent} from 'src/app/shared/components/certificate/certificate.component';
import { LoadingComponent } from './components/loading/loading.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

@NgModule({
  declarations: [
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe,
    ChangeRotationButtonsDirective,
    EmptySpaceSplitPipe,
    WidgetTitleDetailComponent,
    CertificateComponent,
    LoadingComponent,
    NotFoundComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule
  ],
  exports:[
    CardComponent,
    OffcanvasComponent,
    ColorBoxComponent,
    EnumConverterPipe,
    ConvertEnumToArrayPipe,
    EmptySpaceSplitPipe,
    ChangeRotationButtonsDirective,
    WidgetTitleDetailComponent,
    CertificateComponent,
    LoadingComponent,
    NotFoundComponent
  ]
})
export class SharedModule { }

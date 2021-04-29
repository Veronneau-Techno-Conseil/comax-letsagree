import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NameToSvgPipe } from './name-to-svg.pipe';
import { NameToViewboxPipe } from './name-to-viewbox.pipe';

@NgModule({
  declarations: [NameToSvgPipe, NameToViewboxPipe],
  imports: [
    CommonModule
  ],
  exports:[
    NameToSvgPipe,
    NameToViewboxPipe
  ]
})
export class ElementsModule { }

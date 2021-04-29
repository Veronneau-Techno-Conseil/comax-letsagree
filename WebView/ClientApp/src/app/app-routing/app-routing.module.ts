import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Route } from '@angular/router';
import { MainPanelComponent } from './main-panel/main-panel.component';


const routes : Route[] = [
  
]


@NgModule({
  declarations: [MainPanelComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [

  ]
})
export class AppRoutingModule { }

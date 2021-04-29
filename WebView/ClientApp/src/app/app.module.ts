import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { FooterMenuComponent } from './footer-menu/footer-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import  { NgxGraphModule } from "@swimlane/ngx-graph";
import { AboutComponent } from './about/about.component';
import { CreditsComponent } from './credits/credits.component'
import { ElementsModule } from "./elements/elements.module"

@NgModule({
  declarations: [
    AppComponent,
    FooterMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AboutComponent,
    CreditsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'about', component: AboutComponent },
      { path: 'credits', component: CreditsComponent },
    ]),
    NgxGraphModule,
    ElementsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

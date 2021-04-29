import { Pipe, PipeTransform } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { configurations, svgConfig } from "./svg-config"

@Pipe({
  name: 'nameToSvg'
})
export class NameToSvgPipe implements PipeTransform {
  constructor(private sanitizer: DomSanitizer){

  }
  transform(value: any, ...args: any[]): any {
    if(configurations[value].shouldCircle === true){
      return this.sanitizer.bypassSecurityTrustHtml(`<circle cx="${configurations[value].cx}" cy="${configurations[value].cy}" r="400" stroke="currentColor" stroke-width="40" fill="transparent" /> ${configurations[value].path}`);
    }
    else {
      return this.sanitizer.bypassSecurityTrustHtml(`${configurations[value].path}`);
    }
  }

}

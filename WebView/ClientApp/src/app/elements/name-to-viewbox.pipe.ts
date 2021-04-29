import { Pipe, PipeTransform } from '@angular/core';
import { configurations, svgConfig } from "./svg-config";

@Pipe({
  name: 'nameToViewbox'
})
export class NameToViewboxPipe implements PipeTransform {

  transform(value: any, ...args: any[]): any {
    return configurations[value].viewBox;
  }

}
